function [value]=prop_signal(path)
value=0;
fileID = fopen(path);
C = textscan(fileID,'%s %s %s %s','delimiter',',');
fclose(fileID);

a=a(3:size(a,1));
b=b(3:size(b,1));
c=c(3:size(c,1));
d=d(3:size(d,1));
for k=1:size(a,1)
    a1(k,1)=str2double(a{k});
    b1(k,1)=str2double(b{k});
    c1(k,1)=str2double(c{k});
    d1(k,1)=str2double(d{k});
end

%% Troncature

[~,m1]=max(b1);
[m2,~]=find((abs(b1)==0));% On trouve quand on recoit l'impulsion
[n1,~]=find(m2<m1);
[n2,~]=find(a1>=a1(m1));
% On cherche la fin du signal :
[ia,~]=min(find(a1>a1(m1)+15);
[n3,~]=find(a1<a1(ia)); % On coupe au front descendant
n4=intersect(n2,n3);
a2(:,1)=(a1(n4,1)-min(a1(n4,1))); % On met le debut à 0
b2(:,1)=b1(n4,1);
c2(:,1)=c1(n4,1);
d2(:,1)=d1(n4,1);

T=280;
n=10^-5;

valeffX=sqrt(sum(b2^2));
valeffY=sqrt(sum(c2^2));
valeffZ=sqrt(sum(d2^2));

value=sqrt(valeffX^2+valeffY^2+valeffZ^2);