/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  
  static int fibonacci(int n)
  {
      long a = 1, b = 1;
      for(int i=1; i<n;i++)
      {
           Console.Write(a + " ");
            long temp = a;
            a = b;
            b = temp + b;
      }
      Console.WriteLine();
      return 0;
  }
  
  
  
  static void Main() 
  {
    Console.WriteLine("11 fibonacci: "+fibonacci(11));
    
  }
}









