static double Method(int k)
{
    double m = (k + 23.0) / 3.0;
    return m;
}
static double Rec(int k)
{
   
    if (k == 1)
    {
        return Method(k);
    }
    else
    {
        return Method(k) + Rec(k - 1);
    }
}
int n = Convert.ToInt32(Console.ReadLine());
double m = Rec(n);

Console.WriteLine(m);