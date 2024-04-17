using System;

class Program 
{
  public static void Main (string[] args) 
  {
    double total = 0;

    for (int q = 0; q <= 63; q = q + 1)
    {
      total = total + Math.Pow(2, q);
    }
    Console.WriteLine ($"O números de grãos de trigo é igual a {total}");

  }
}