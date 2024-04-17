using System;

class Program
{
  public static void Main (string[] args) 
  {
    double total = 0;
    int num;

    for (num = 1; num <= 10; num = num + 1)
    {
      total = total + num/(3.0);
    }

    Console.WriteLine ($"A soma é igual a {total}");

  }
}