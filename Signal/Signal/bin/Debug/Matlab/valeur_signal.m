function [value]=valeur_signal(path)

fileID = fopen(path);
C = textscan(fileID,'%s %s %s %s','delimiter',',');
fclose(fileID);
a=C{1};
b=C{2};
c=C{3};
d=C{4};

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
[ia,~]=min(find(a1>a1(m1)+100));
[na,~]=max(find(diff(b1)==min(diff(b1(ia:length(b1))))));
[n3,~]=find(a1<a1(na)); % On coupe au front descendant
n4=intersect(n2,n3);
a2(:,1)=(a1(n4,1)-min(a1(n4,1))); % On met le debut à 0
b2(:,1)=b1(n4,1);
c2(:,1)=c1(n4,1);
d2(:,1)=d1(n4,1);

% fileID = fopen('exp.csv','w');
% fprintf(fileID,'%2f,%2f,%2f,%2f\n',a2,b2,c2,d2);
% fclose(fileID);

%% Fréquence
% On trouve la valeur de a2 où les 3 courbes sont à 0

[zb,~]=find((b2==0)&(a2<100));
[zc,~]=find((c2==0)&(a2<100));
[zd,~]=find((d2==0)&(a2<100));

z1b=floor(median(zb));
z1c=floor(median(zc));
z1d=floor(median(zd));
z1=floor(median([z1b z1c z1d]));

[zb,~]=find((b2==0)&(a2>100));
[zc,~]=find((c2==0)&(a2>100));
[zd,~]=find((d2==0)&(a2>100));

z2b=floor(median(zb));
z2c=floor(median(zc));
z2d=floor(median(zd));
z2=floor(median([z2b z2c z2d]));

T=2*(a2(z2)-a2(z1));
f=1/T;

%% Phase

phi=(pi/2)-2*pi*(f)*a2(z1);

%% Amplitude
% Etant donné le fort bruit du front montant, on commence l'analyse 10µs
% après le debut du signal

[z12,~]=min(find(abs(a2-(a2(1)+10))<0.1));
b12=b2(z12);
[z122,~]=find((b2==b12)&(a2<a2(z1)));
zb12=floor(median(z122));
Ax=b12/(cos((2*pi*(f))*a2(zb12)+phi));
c12=c2(z12);
[z122,~]=find((c2==c12)&(a2<a2(z1)));
zc12=floor(median(z122));
Ay=c12/(cos((2*pi*(f))*a2(zc12)+phi));
d12=d2(z12);
[z122,~]=find((d2==d12)&(a2<a2(z1)));
zd12=floor(median(z122));
Az=d12/(cos((2*pi*(f))*a2(zd12)+phi));

if (Az==0||Ay==0||Ax==0)
    value=err;
%% Atténuation exponentielle
else
[ia,~]=find(a2>100);
[ib,~]=max(find(diff(b2)==min(diff(b2(ia:length(b2))))));
[ic,~]=max(find(diff(c2)==min(diff(c2(ia:length(c2))))));
[id,~]=max(find(diff(d2)==min(diff(d2(ia:length(d2))))));
i=median([ib ic id]);

k=100;
t=a2(i-k);

enx=-log(b2(i-k)/(Ax*cos(2*pi*(f)*t+phi)))/(t);
eny=-log(c2(i-k)/(Ay*cos(2*pi*(f)*t+phi)))/(t);
enz=-log(d2(i-k)/(Az*cos(2*pi*(f)*t+phi)))/(t);
n=median([enx eny enz]);

%% Zoom sur les courbes de faible amplitude (automatique)

A=max([Ax Ay Az]);
% if (Ax<A/8)
%     figure()
%     plot(a2,b2,a2,cosine(a2,f,Ax,phi,n));
%     legend('Dérivée du champ x')
%     xlabel('temps µs');
% end
% if (Ay<A/8)
%     figure()
%     plot(a2,c2,a2,cosine(a2,f,Ay,phi,n));
%     legend('Dérivée du champ y')
%     xlabel('temps µs');
% end
% if (Az<A/8)
%     figure()
%     plot(a2,d2,a2,cosine(a2,f,Az,phi,n));
%     legend('Dérivée du champ z')
%     xlabel('temps µs');
% end

%% Passage mV à T/us
Ax=Ax*1.4;
Ay=Ay*1.4;
Az=Az*1.4;

%% Integration
% fonction integ

%% Zoom sur les courbes de faible amplitude (automatique)

A=max([Ax Ay Az]);
% if (Ax<A/8)
%     figure()
%     plot(a2,integ(a2,f,Ax,phi,n));
%     legend('Champ x')
%     xlabel('temps µs');
% end
% if (Ay<A/8)
%     figure()
%     plot(a2,integ(a2,f,Ay,phi,n));
%     legend('Champ y')
%     xlabel('temps µs');
% end
% if (Az<A/8)
%     figure()
%     plot(a2,integ(a2,f,Az,phi,n));
%     legend('Champ z')
%     xlabel('temps µs');
% end

%% Norme
Axi=max(integ(a2,f,Ax,phi,n));
Ayi=max(integ(a2,f,Ay,phi,n));
Azi=max(integ(a2,f,Az,phi,n));
value = sqrt(Axi^2+Ayi^2+Azi^2);
end