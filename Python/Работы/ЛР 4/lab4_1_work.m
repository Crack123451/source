%% ���ݧԧ��ڧ�� ���ڧ�ܧ� �ӧ֧ܧ����� ��ާ֧�֧ߧڧ�
fileName = '1.MP4'; 
obj = VideoReader(fileName);
%numFrames = obj.NumberOfFrames;
for k = 1000: 1001
     frame = read(obj,k);
     %imshow(frame);
     imwrite(frame,strcat(num2str(k),'.jpg'),'jpg');
end
I1=imread('1000.jpg');
I2=imread('1001.jpg');
 I1 = rgb2gray(I1);
 I2 = rgb2gray(I2);
  figure
  imshow(I1);
  figure
  imshow(I2);

 
% �����֧է֧ݧ�֧� ��ѧ٧ާ֧�� �ܧѧէ��
[Ysize, Xsize, kol]=size(I1);
% ���ߧڧ�ڧѧݧڧ٧ڧ��֧� �ߧѧ�ѧݧ�ߧ�� ��ѧ�ѧާ֧���
B_Size=6;
H_BSize=B_Size/2;
Stride=5;
S_Window=70;
%% �����֧է֧ݧ֧ߧڧ� �ӧ֧ܧ����� ��ާ֧�֧ߧڧ� 
figure;
hold on
for x=H_BSize:Stride:Xsize-H_BSize
    for y=H_BSize:Stride:Ysize-H_BSize
        It=0;
        f=0;
        
        for i=x-H_BSize+1:1:x+H_BSize
            for j=y-H_BSize+1:1:y+H_BSize
                It=It+double(I1(j,i));
                f=f+double(I2(j,i));
            end
        end    
        %% �����֧է֧ݧ�֧� �٧�ߧ� ���ڧ�ܧ�
        Size_i=S_Window;
        x_center=x;
        y_center=y;
        It_1=-1;
        if (abs(It-f)>5)
            while Size_i>=B_Size
                x_search1=x-Size_i;
                if x_search1<0
                    x_search1=1;
                end
                
                x_search2=x+Size_i;
                if x_search2>Xsize
                    x_search2=Xsize;
                end
                
                y_search1=y-Size_i;
                if y_search1<0
                    y_search1=1;
                end
                
                y_search2=y+Size_i;
                if y_search2>Ysize
                    y_search2=Ysize;
                end
                %% ����ҧڧ�ѧ֧� 9 ����֧� �� �٧�ߧ� ���ڧ�ܧ�
                x_c(1)=x_center; y_c(1)=y_center;
                x_c(2)=x_search1+H_BSize; y_c(2)=y_center;
                x_c(3)=x_search1+H_BSize; y_c(3)=y_search2-H_BSize;
                x_c(4)=x_center; y_c(4)=y_search2-H_BSize;
                x_c(5)=x_search2-H_BSize; y_c(5)=y_search2-H_BSize;
                x_c(6)=x_search2-H_BSize; y_c(6)=y_center;
                x_c(7)=x_search2-H_BSize; y_c(7)=y_search1+H_BSize;
                x_c(8)=x_center; y_c(8)=y_search1+H_BSize;
                x_c(9)=x_search1+H_BSize; y_c(9)=y_search1+H_BSize;
                %% �����ڧ�ݧ�֧� �ڧ�ܧѧا֧ߧڧ� �� �ߧѧ��էڧ� ����ܧ� �� �ߧѧڧާ֧ߧ��ڧާ� �ڧ�ܧѧا֧ߧڧ�ާ� 
                for l=1:1:9
                    flag=0;
                    for i=x_c(l)-H_BSize+1:1:x_c(l)+H_BSize
                        for j=y_c(l)-H_BSize+1:1:y_c(l)+H_BSize
                            flag=flag+double(I2(j,i));
                        end
                    end
                    %% ���ާ֧�ѧ֧� ��֧ߧ�� �� ����ܧ� �� �ߧѧڧާ֧ߧ��ڧާ� �ڧ�ܧѧا֧ߧڧ�ާ�. ���ѧ� ����ѧ֧��� �ߧ֧ڧ٧ާ֧ߧߧ��
                    if (It_1==-1)||(abs(It-flag)<abs(It-It_1))
                        It_1=flag;
                        x_center=x_c(l);
                        y_center=y_c(l);
                    end
                end
                %% ���ާ֧ߧ��ѧ֧� ��ѧ� �� �էӧ� ��ѧ٧�
                Size_i=fix(Size_i/2);
            end
        end
        %% ������ڧ� �ӧ֧ܧ���� ��ާ֧�֧ߧڧ�
        plot([x x_center], [y y_center])
        vectArray(1,kol)=x;
        vectArray(2,kol)=x_center;
        vectArray(3,kol)=y;
        vectArray(4,kol)=y_center;
        kol= kol + 1;
    end
end
%% �������ѧߧѧӧݧڧӧѧ֧� �ڧ٧�ҧ�ѧا֧ߧڧ�
for l=1:1:kol-1
    for i=-H_BSize+1:1:H_BSize
        for j=-H_BSize+1:1:H_BSize
            if ((vectArray(4,l)+j)<=Ysize)&((vectArray(3,l)+j)<=Ysize)&((vectArray(2,l)+i)<=Xsize)&((vectArray(1,l)+i)<=Xsize)
                ImagChange(vectArray(4,l)+j,vectArray(2,l)+i)=I1(vectArray(3,l)+j,vectArray(1,l)+i);
            end
        end
    end
end
imwrite(ImagChange, 'ImagChange.jpg');
