using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int total = 0, num;

    for (num = 1; num <= 10; num = num + 1)
    {
      total = total + num*num;
    }

    Console.WriteLine ($"A soma é igual a {total}");

  }
}