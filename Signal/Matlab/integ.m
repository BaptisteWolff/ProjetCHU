function[y]=integ(x,f,A,phi,n)

y=((((A*2*pi*f)*sin((2*pi*f).*x+phi)).*exp(-n.*x))-(((A*n)*cos((2*pi*f).*x+phi)).*exp(-n.*x)))/(4*(f^2)*(pi^2)+(n^2));