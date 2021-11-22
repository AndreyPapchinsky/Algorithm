using System;
public class Program
{

    private static double Method(double target)
    {
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
    public static void Main()
    {
        double target = 2023;

        double x = Method(target);
        
        Console.WriteLine(x);
        Console.WriteLine(x * x);
    }
}
