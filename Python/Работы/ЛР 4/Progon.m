clear;
close all;

% ����� �� ������ 2 ���������������� �����
t_1 = imread('D:/4-01.png');
t = imread('D:/4-02.png');

% ����������� ����������� � ������� ������
for i = 1:size(t_1,1)
    for j = 1:size(t_1,2)
       Iser1(i,j) = 0.299*t_1(i,j,1)+0.587*t_1(i,j,2)+0.114*t_1(i,j,3); 
       Iser2(i,j) = 0.299*t(i,j,1)+0.587*t(i,j,2)+0.114*t(i,j,3); 
    end
end

% ������� ����������� t_1 � t
figure, imshow(Iser1);
title ('���� t-1 � �������� ������');
figure, imshow(Iser2);
title ('���� t � �������� ������');

% ���������� ������� �����
[sizeX, sizeY, number] = size(Iser1);
% ������� ������� ���������
sizeBlock = 16; % ������ �����
sizeWindow = 60; % ������ ���� ������
stride = 16; % ��� �� ���������� �����
step = 1; % ������� ���

% ����������� ������� ��������

% ���� ������ �������� ��������
figure;
hold on
for px = sizeBlock/2:stride:sizeX-sizeBlock/2
    for py = sizeBlock/2:stride:sizeY-sizeBlock/2
        metricSAD_min = 0;
        flag = 0;
        
        % ������� ���� t-1
        x_center1 = px;
        y_center1 = py;
        x = 1;
        y = 1;
        for i = px-sizeBlock/2+1:px+sizeBlock/2
            for j = py-sizeBlock/2+1:py+sizeBlock/2
                Bt1(x,y) = double(Iser1(i,j)); % ���� t-1
                y = y+1;
            end
            x = x+1;
            y = 1;
        end
        
        % ���������� ������������ ��� ������ ����������� ����
        % �� X
        if px <= sizeBlock 
            x1Coef = 0;
            x2Coef = sizeWindow/2-sizeBlock/2;
        elseif px >= sizeX-sizeBlock/2
            x1Coef = sizeWindow/2-sizeBlock/2-1;
            x2Coef = 0;
        else
            x1Coef = sizeWindow/2-sizeBlock/2-1;
            x2Coef = sizeWindow/2-sizeBlock/2;
        end
        
        % �� Y
        if py <= sizeBlock
            y1Coef = 0;
            y2Coef = sizeWindow/2-sizeBlock/2;
        elseif py >= sizeY-sizeBlock/2
            y1Coef = sizeWindow/2-sizeBlock/2-1;
            y2Coef = 0;
        else
            y1Coef = sizeWindow/2-sizeBlock/2-1;
            y2Coef = sizeWindow/2-sizeBlock/2;
        end
        
        % ����������� ���� ������

        xCenter = x_center1; 
        yCenter = y_center1;
        for wx = px-x1Coef:step:px+x2Coef     
            for wy = py-y1Coef:step:py+y2Coef  
                
                % ��������� ���� � ����� t
                x_c = wx;
                y_c = wy;
                x = 1;
                y = 1;
                for i = wx-sizeBlock/2+1:wx+sizeBlock/2
                   for j = wy-sizeBlock/2+1:wy+sizeBlock/2
                       Bt2(x,y) = double(Iser2(i,j)); % ���� t
                       y = y+1;
                   end
                   x = x+1;
                   y = 1;
                end
                
                % ��������� ������
                for i = 1:1:size(Bt1,2)
                    for j = 1:1:size(Bt1,1)
                         S(i,j) = (abs(Bt1(i,j)-Bt2(i,j)));
                    end
                end
                SAD = sum(sum(S));
                if flag == 0
                    metricSAD_min = SAD;
                    flag = 1;
                end
                
                % ����������� ���������� ������������� �����
                if SAD < metricSAD_min
                    metricSAD_min = SAD;
                    xCenter = x_c;
                    yCenter = y_c;
                end
            end
        end 
        
        % ���������� ������� �������� ��������
        plot([x_center1 xCenter], [y_center1 yCenter])
        title ('������ �������� ��������');
        vectArray(1,number)=x_center1;
        vectArray(2,number)=xCenter;
        vectArray(3,number)=y_center1;
        vectArray(4,number)=yCenter;
        number= number + 1;        
        py = py - 1;
    end
    px = px - 1;
end

% ��������������� ���� t-1, ���� ���� t

for l=1:1:number-1 
    for i=-sizeBlock/2+1:sizeBlock/2
        for j=-sizeBlock/2+1:sizeBlock/2
            if ((vectArray(4,l)+j)<=sizeY)&((vectArray(3,l)+j)<=sizeY)&((vectArray(2,l)+i)<=sizeX)&&((vectArray(1,l)+i)<=sizeX) 
                ImagChange(vectArray(1,l)+j,vectArray(3,l)+i)=Iser2(vectArray(2,l)+j,vectArray(4,l)+i); 
            end
        end
    end
end

%������� ������������ �����������
figure, imshow(ImagChange);
title ('�������������� ���� t-1');