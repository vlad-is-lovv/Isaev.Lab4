static void Result(int x, int y,double a,double b,char k,char z)
{
        double m1 = 12*a - 3;
        double m2 = -2*b;

        double m3 = Math.Max(m1, m2);
    Console.WriteLine(m3);

    int q1 = 12 * x - 3;
    int q2 = -2 * y;
    int q3 = Math.Max(q1, q2);
    Console.WriteLine(q3);

    int s1 = 12 * k - 3;
    int s2 = -2 * z;
    int s3 = Math.Max(k, z);
    Console.WriteLine(s3);
}

Console.WriteLine("Введите целые числа...");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите дробные числа...");
double z = Convert.ToDouble(Console.ReadLine());
double w = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите символы...");
char q = Convert.ToChar(Console.ReadLine());
char k = Convert.ToChar(Console.ReadLine());

Result(x, y, z, w,q,k); 
