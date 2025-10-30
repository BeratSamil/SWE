using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayi girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (AsalMi(sayi))
            Console.WriteLine($"{sayi} bir asal sayıdır.");
        else
            Console.WriteLine($"{sayi} bir asal sayı değildir.");
    }

    static bool AsalMi(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
