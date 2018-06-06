clear;
close all;

video = VideoReader('D:/Spasti_kota.mp4');
% Выбор кадров
FrNo1 = 1860;
FrNo2 = 1862;
img_fr1 = read(video,FrNo1);
img_fr2 = read(video,FrNo2);

x = size(img_fr1,1);
y = size(img_fr1,2);
% Презование RGB в ч/б
for xx = 1:1:x
    for yy = 1:1:y
       F1(xx,yy) = 0.299*img_fr1(xx,yy,1)+0.587*img_fr1(xx,yy,2)+0.114*img_fr1(xx,yy,3); 
       F2(xx,yy) = 0.299*img_fr2(xx,yy,1)+0.587*img_fr2(xx,yy,2)+0.114*img_fr2(xx,yy,3); 
    end
end

figure, imshow(F1);
title ('Кадр t-1 в оттенках серого');
figure, imshow(F2);
title ('Кадр t в оттенках серого');

% Определяем размеры кадра
[Xsize, Ysize, kol] = size(F1);
% Инициализируем начальные параметры
BlokSize = 16;
WindowSize = 48;
Stride = 16;
Step = 1;
% ================== Определение векторов смещения =======================
% Весь рисунок
figure;
hold on
for px = BlokSize/2:Stride:Xsize-BlokSize/2
    for py = BlokSize/2:Stride:Ysize-BlokSize/2
        SADmin = 0;
        flag = 0;
% ===== Искомый блок кадра t-1 ============================================
        x_center1 = px;
        y_center1 = py;
        x = 1;
        y = 1;
        for i = px-BlokSize/2+1:1:px+BlokSize/2
            for j = py-BlokSize/2+1:1:py+BlokSize/2
                Bt1(x,y) = double(F1(i,j)); % кадр t-1
                y = y+1;
            end
            x = x+1;
            y = 1;
        end
        % ===== Коэффициент для поиска допустимого окна ===========================
        %----------- X ------------
        if px <= BlokSize 
            koeff_x1 = 0;
            koeff_x2 = WindowSize/2-BlokSize/2;
        elseif px >= Xsize-BlokSize/2
            koeff_x1 = WindowSize/2-BlokSize/2-1;
            koeff_x2 = 0;
        else
            koeff_x1 = WindowSize/2-BlokSize/2-1;
            koeff_x2 = WindowSize/2-BlokSize/2;
        end
        %----------- Y ------------
        if py <= BlokSize
            koeff_y1 = 0;
            koeff_y2 = WindowSize/2-BlokSize/2;
        elseif py >= Ysize-BlokSize/2
            koeff_y1 = WindowSize/2-BlokSize/2-1;
            koeff_y2 = 0;
        else
            koeff_y1 = WindowSize/2-BlokSize/2-1;
            koeff_y2 = WindowSize/2-BlokSize/2;
        end
% ===== Определение окна поиска ===========================================
        x_center = x_center1; 
        y_center = y_center1;
        for wx = px-koeff_x1:Step:px+koeff_x2     
            for wy = py-koeff_y1:Step:py+koeff_y2   
                     
                % Возможный блок в кадре t
                x_c = wx;
                y_c = wy;
                x = 1;
                y = 1;
                for i = wx-BlokSize/2+1:1:wx+BlokSize/2
                   for j = wy-BlokSize/2+1:1:wy+BlokSize/2
                       Bt2(x,y) = double(F2(i,j)); % кадр t
                       y = y+1;
                   end
                   x = x+1;
                   y = 1;
                end
                % Сравнение блоков
                for i = 1:1:size(Bt1,2)
                    for j = 1:1:size(Bt1,1)
                         S(i,j) = (abs(Bt1(i,j)-Bt2(i,j)));
                        % S(i,j) = (Bt1(i,j)-Bt2(i,j))^2;
                    end
                end
                SAD = sum(sum(S));
                if flag == 0
                    SADmin = SAD;
                    flag = 1;
                end
                % Определение минимально отличающегося блока
                if SAD < SADmin
                    SADmin = SAD;
                    x_center = x_c;
                    y_center = y_c;
                end
                %tableSAD(wx,wy) = SADmin;
 
%                 if(SADmin == 0)
%                     break;
%                 end
            end
 
%             if(SADmin == 0)
%                 break;
%             end
        end 
        % построение вектора смещения
        plot([x_center1 x_center], [y_center1 y_center])
        vectArray(1,kol)=x_center1;
        vectArray(2,kol)=x_center;
        vectArray(3,kol)=y_center1;
        vectArray(4,kol)=y_center;
        kol= kol + 1;
        
        py = py - 1;
    end
    px = px - 1;
end
% ================= Восстанавление изображения ===========================
for l=1:1:kol-1 
    for i=-BlokSize/2+1:1:BlokSize/2
        for j=-BlokSize/2+1:1:BlokSize/2
            if ((vectArray(4,l)+j)<=Ysize)&((vectArray(3,l)+j)<=Ysize)&((vectArray(2,l)+i)<=Xsize)&&((vectArray(1,l)+i)<=Xsize) 
                ImagChange(vectArray(1,l)+j,vectArray(3,l)+i)=F2(vectArray(2,l)+j,vectArray(4,l)+i); 
            end
        end
    end
end
imwrite(uint8(ImagChange), 'RestoredFrame.png');
figure
I = imread('RestoredFrame.png');
imshow(I, 'InitialMagnification', 100);
