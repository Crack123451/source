clear;
close all;

I=imread('D:/Diag.jpg');
G=zeros (size(I,1)+2,size(I,2)+2); %������� ������ � ������
G=uint8(G);

Ser=zeros (size(I,1),size(I,2));
Ser=uint8(Ser);

for i=1:size(I,1)
    for j=1:size(I,2)
    Ser(i,j)= uint8(I(i,j,1)*0.299+I(i,j,2)*0.587+I(i,j,3)*0.114);
   
    end
end 
figure,imshow(Ser);

for i=1:size(I,1)
    for j=1:size(I,2)
    G(i+1,j+1)= Ser(i,j);
    end
end 
%��������� ������ ��� ���������� �����

G(1,1)=Ser(1,1);
G(1,size(I,2)+2)=Ser(1,size(I,2));
G(size(I,1)+2,1)=Ser(size(I,1),1);
G(size(I,1)+2,size(I,2)+2)=Ser(size(I,1),size(I,2));
%��������� ���� �����

for j=1:size(I,2) %�������� �� �������� (1 � ��������� ������)
    G(1,j+1)=Ser(1,j);
    G(size(I,1)+2,j+1)=Ser(size(I,1),j);
end

for i=1:size(I,1) %�������� �� ������� (1 � ���������� �������)
    G(i+1,1)=Ser(i,1);
    G(i+1,size(I,2)+2)=Ser(i,size(I,2));
end

k=zeros(255,1);
for i=1:size(G,1)
   for j=1:size(G,2)       
       k(G(i,j)+1)=k(G(i,j)+1)+1;
   end
end

figure,plot(k);
title ('����������� ���������� �����������');

%����� ������
G=int16(G);
Gx=zeros (size(I,1),size(I,2)); %������� ������ Gx
Gx=int16(Gx);
Gy=zeros (size(I,1),size(I,2)); %������� ������ Gy
Gy=int16(Gy);
Gitog=zeros (size(I,1),size(I,2)); %������� ������ Gitog
Gitog=uint16(Gitog);

for i=2:(size(G,1)-1)
    for j=2:(size(G,2)-1)
        Gx(i-1,j-1)= G(i-1,j-1)-G(i-1,j+1)+2*G(i,j-1)-2*G(i,j+1)+G(i+1,j-1)-G(i+1,j+1);
        Gy(i-1,j-1)= -G(i-1,j-1)-2*G(i-1,j)-G(i-1,j+1)+G(i+1,j-1)+2*G(i+1,j)+G(i+1,j+1);
        %Gitog(i-1,j-1)= abs(Gx(i-1,j-1))+abs(Gy(i-1,j-1));
    end
end
Gitog = abs(Gx) + abs(Gy);
k=zeros(65535,1);
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       k(Gitog(i,j)+1)=k(Gitog(i,j)+1)+1;
   end
end
figure,plot(k);
title ('����������� �� ���������� ������ ������');

L=max(max(Gitog));
Lmin=min(min(Gitog));

%[0,510] -> [0,65535] 
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       Gitog(i,j) = double(Gitog(i,j))*(65535.0/double(L));
   end
end

k=zeros(65535,1);
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       k(Gitog(i,j)+1)=k(Gitog(i,j)+1)+1;
   end
end
figure,plot(k);
title ('����������� ����� ���������� ������ ������');

figure,imshow(Gitog);
title ('����������� ����� ������ ������');
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%����� ��������
Gx=zeros (size(I,1),size(I,2)); %������� ������ Gx
Gx=int16(Gx);
Gy=zeros (size(I,1),size(I,2)); %������� ������ Gy
Gy=int16(Gy);
Gitog=zeros (size(I,1),size(I,2)); %������� ������ Gitog
Gitog=uint16(Gitog);

for i=2:(size(G,1)-1)
    for j=2:(size(G,2)-1)
        Gx(i-1,j-1)= G(i-1,j-1)-G(i-1,j+1)+G(i,j-1)-G(i,j+1)+G(i+1,j-1)-G(i+1,j+1);
        Gy(i-1,j-1)= -G(i-1,j-1)-G(i-1,j)-G(i-1,j+1)+G(i+1,j-1)+G(i+1,j)+G(i+1,j+1);
        %Gitog(i-1,j-1)= abs(Gx(i-1,j-1))+abs(Gy(i-1,j-1));
    end
end
Gitog = abs(Gx) + abs(Gy);
k=zeros(65535,1);
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       k(Gitog(i,j)+1)=k(Gitog(i,j)+1)+1;
   end
end
figure,plot(k);
title ('����������� �� ���������� ������ ��������');

L=max(max(Gitog));
Lmin=min(min(Gitog));

%[0,510] -> [0,65535] 
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       Gitog(i,j) = double(Gitog(i,j))*(65535.0/double(L));
   end
end

k=zeros(65535,1);
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       k(Gitog(i,j)+1)=k(Gitog(i,j)+1)+1;
   end
end
figure,plot(k);
title ('����������� ����� ���������� ������ ��������');

figure,imshow(Gitog);
title ('����������� ����� ������ ��������');
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%����� �������
Gx=zeros (size(I,1),size(I,2)); %������� ������ Gx
Gx=int8(Gx);
Gy=zeros (size(I,1),size(I,2)); %������� ������ Gy
Gy=int8(Gy);
Gitog=zeros (size(I,1),size(I,2)); %������� ������ Gitog
Gitog=uint8(Gitog);

for i=2:(size(G,1)-1)
    for j=2:(size(G,2)-1)
        Gx(i-1,j-1)= G(i,j)-G(i+1,j+1);
        Gy(i-1,j-1)= G(i,j+1)-G(i+1,j);
    end
end
Gitog = abs(Gx) + abs(Gy);

k=zeros(256,1);
for i=1:size(Gitog,1)
   for j=1:size(Gitog,2)       
       k(Gitog(i,j)+1)=k(Gitog(i,j)+1)+1;
   end
end

figure,plot(k)
title ('����������� ����� ������ �������');

figure,imshow(Gitog);
title ('����������� ����� ������ �������');
