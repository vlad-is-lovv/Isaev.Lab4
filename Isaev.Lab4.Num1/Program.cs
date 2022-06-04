static double ResultDouble(double x, double y)
{
        double m = 12*x - 3;
        double s = -2*y;

        double l = Math.Max(m, s);
    return l;
}
static int ResultInt(int x, int y)
{
    int m = 12 * x - 3;
    int s = -2 * y;
    int l = Math.Max(m, s);
    return l;
}
static int ResultChar(char x, char y)
{
    int m = 12 * x - 3;
    int s = -2 * y;
    int l = Math.Max(m, s);
    return l;
}

Console.WriteLine("Введите целые числа...");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultInt(x, y));

Console.WriteLine("Введите дробные числа...");
double z = Convert.ToDouble(Console.ReadLine());
double w = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ResultDouble(z, w));

Console.WriteLine("Введите символы...");
char q = Convert.ToChar(Console.ReadLine());
char k = Convert.ToChar(Console.ReadLine());
Console.WriteLine(ResultChar(q, k));

