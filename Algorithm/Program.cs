

double target = 2023;
double x = 1;
double oldx;


RootSearch();

Console.WriteLine(x);
Console.WriteLine(x * x);

void RootSearch () { 
do
{
    oldx = x;
    x = (x + target / x) / 2;
}
while (oldx != x);

}
