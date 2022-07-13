int a1 = 11;
int b1 = 34;
int c1 = 12;
int a2 = 41;
int b2 = 50;
int c2 = 23;
int a3 = 6;
int b3 = 3;
int c3 = 22;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);