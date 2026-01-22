using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace triangleInequality;

class Program
{

    static string triangleIn(int a, int b, int c)
    {
        string result = "not possible";
        if (Math.Abs(b - c) < a && a < b + c && Math.Abs(a - c) < b && b < a + c && Math.Abs(a - b) < c && c < a + b)
        {
            result = "possible";
            if (a*a==b*b+c*c || b*b==a*a+c*c || c*c==a*a+b*b)
            {
                result = "possible\nrectangular triangle";
            }
        }
        else
        {
            result = "not possible";
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.Write("enter length of side1:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter length of side2:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter length of side3:");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(triangleIn(a, b, c));
        



    }
}
