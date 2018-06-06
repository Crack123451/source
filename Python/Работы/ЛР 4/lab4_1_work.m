%% 均抖忍抉把我找技 扭抉我扼抗忘 志快抗找抉把抉志 扼技快投快扶我攸
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

 
% 妍扭把快忱快抖攸快技 把忘戒技快把抑 抗忘忱把忘
[Ysize, Xsize, kol]=size(I1);
% 妒扶我扯我忘抖我戒我把批快技 扶忘折忘抖抆扶抑快 扭忘把忘技快找把抑
B_Size=6;
H_BSize=B_Size/2;
Stride=5;
S_Window=70;
%% 妍扭把快忱快抖快扶我快 志快抗找抉把抉志 扼技快投快扶我攸 
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
        %% 妍扭把快忱快抖攸快技 戒抉扶批 扭抉我扼抗忘
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
                %% 圾抑忌我把忘快技 9 找抉折快抗 志 戒抉扶快 扭抉我扼抗忘
                x_c(1)=x_center; y_c(1)=y_center;
                x_c(2)=x_search1+H_BSize; y_c(2)=y_center;
                x_c(3)=x_search1+H_BSize; y_c(3)=y_search2-H_BSize;
                x_c(4)=x_center; y_c(4)=y_search2-H_BSize;
                x_c(5)=x_search2-H_BSize; y_c(5)=y_search2-H_BSize;
                x_c(6)=x_search2-H_BSize; y_c(6)=y_center;
                x_c(7)=x_search2-H_BSize; y_c(7)=y_search1+H_BSize;
                x_c(8)=x_center; y_c(8)=y_search1+H_BSize;
                x_c(9)=x_search1+H_BSize; y_c(9)=y_search1+H_BSize;
                %% 圾抑折我扼抖攸快技 我扼抗忘忪快扶我攸 我 扶忘抒抉忱我技 找抉折抗批 扼 扶忘我技快扶抆扮我技我 我扼抗忘忪快扶我攸技我 
                for l=1:1:9
                    flag=0;
                    for i=x_c(l)-H_BSize+1:1:x_c(l)+H_BSize
                        for j=y_c(l)-H_BSize+1:1:y_c(l)+H_BSize
                            flag=flag+double(I2(j,i));
                        end
                    end
                    %% 妊技快投忘快技 扯快扶找把 志 找抉折抗批 扼 扶忘我技快扶抆扮我技我 我扼抗忘忪快扶我攸技我. 宋忘忍 抉扼找忘快找扼攸 扶快我戒技快扶扶抑技
                    if (It_1==-1)||(abs(It-flag)<abs(It-It_1))
                        It_1=flag;
                        x_center=x_c(l);
                        y_center=y_c(l);
                    end
                end
                %% 孝技快扶抆扮忘快技 扮忘忍 志 忱志忘 把忘戒忘
                Size_i=fix(Size_i/2);
            end
        end
        %% 妊找把抉我技 志快抗找抉把抑 扼技快投快扶我抄
        plot([x x_center], [y y_center])
        vectArray(1,kol)=x;
        vectArray(2,kol)=x_center;
        vectArray(3,kol)=y;
        vectArray(4,kol)=y_center;
        kol= kol + 1;
    end
end
%% 圾抉扼扼找忘扶忘志抖我志忘快技 我戒抉忌把忘忪快扶我快
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
