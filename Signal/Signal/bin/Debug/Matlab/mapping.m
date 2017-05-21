function [maxi,mini]=mapping(values,position,path)
% values tableau des valeurs calculées avec la carte
% position position x,y,z

scatter=zeros(length(values),4);
scatter(:,1)=values;
scatter(:,2)=position(1);
scatter(:,3)=position(2);
scatter(:,4)=position(3);

[maxi,im]=max(values);
[~,im2]=find(values==maxi/2);
[~,imi2]=find((values>maxi/2)&(value<maxi));
[mini,~]=min(values);

figure(1)
scatter3(position(im),1,'magenta');
hold on;
scatter3(position(imi2),1,'red');
hold on;
scatter3(position(im2),1,'yellow');

s=strcat(path,'.png');
saveas(gcf,s);