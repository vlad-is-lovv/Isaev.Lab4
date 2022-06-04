static double Method(int k)
{
    double s = (k*k) /3.0;
    return s;
}
static double Rec(int k)
{
    if (k == 1)
    {
        return Method(k);
    }
    else
    {
        return Method(k) * Rec(k - 1);
    }

}
    int n = Convert.ToInt32(Console.ReadLine());
    double s = Rec(n);


    Console.WriteLine(s);