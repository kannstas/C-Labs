

double target = 2023;


Exit(RootSearch(target));


static double RootSearch (double target) {
    double x = 1;
    double oldx;
    do
{
    oldx = x;
    x = (x + target / x) / 2;
}
while (oldx != x);

    return x;
}

static void Exit(double x)
{
    Console.WriteLine(x);
    Console.WriteLine(x * x);
}