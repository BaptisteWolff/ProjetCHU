function [maxi,mini]=mapping(values,positionX,positionY,positionZ,path)
% values tableau des valeurs calculées avec la carte
% position position x,y,z

scatter=zeros(length(values),4);
scatter(:,1)=values;
scatter(:,2)=positionX;
scatter(:,3)=positionY;
scatter(:,4)=positionZ;

[maxi,im]=max(values);
[~,im2]=min(values-maxi/2);
[~,imi2]=find((values>maxi/2)&(values<maxi));
[mini,~]=min(values);

size = 50;

figure(1)
scatter3(positionX(im),positionY(im),positionZ(im),size,'MarkerFaceColor',[0.75 0 0.75]);
hold on;
scatter3(positionX(imi2),positionY(imi2),positionZ(imi2),size,'MarkerFaceColor',[1 0 0]);
hold on;
scatter3(positionX(im2),positionY(im2),positionZ(im2),size,'MarkerFaceColor',[0.75 0.75]);

s=strcat(path,'.png');
saveas(gcf,s);