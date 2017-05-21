function[y]=cosine(x,f,A,phi,n)
y=(A*cos((2*pi*f).*x+phi)).*exp(-n.*x);