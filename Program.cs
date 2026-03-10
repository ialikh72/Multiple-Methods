using System;
class Program
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("enter a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter b:");
        b = Convert.ToInt32(Console.ReadLine());
        Sum(a, b);
        Sub(a, b);
        Mul(a, b);
        Div(a, b);

    }
    static void Sum(int x, int y)
    {
       
        Console.WriteLine("sum is:"+( x += y));
    }
    static void Sub(int x, int y)
    {
        Console.WriteLine("sub is:"+(x -= y)) ;
    }
    static void Mul(int x, int y)
    {
        Console.WriteLine("mul is:"+(x *= y));
    }
    static void Div(int x, int y)
    {
        validate(x, y);
        Console.WriteLine("div is:"+(x /= y));
    }
    static void validate(int a, int b)
    {
        if(b==0)
            Console.WriteLine("div is not possible");
        else
            Console.WriteLine("div is possible");
    }
}
