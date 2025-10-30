/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Fackt {
  static long factorialCalc(int number) 
  {
   int sum=1;
   for(int i=1; i<= number; i++)
   {
        sum = sum * i;
   }
    return sum;
  }

static long factorialCalc2(int number) 
  {
   int sum=1;
   int counter=1;
   
   while(counter<=number)
   {
       sum = sum * counter;
       counter++;
   }
    return sum;
  }


  static void Main() 
  {
   Console.WriteLine("result is "+factorialCalc(5));
   Console.WriteLine("result is "+factorialCalc(0));
   Console.WriteLine("result is "+factorialCalc2(5));
   
  }
}