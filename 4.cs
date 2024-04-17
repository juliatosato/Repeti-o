using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int total = 1, num, i;

    Console.WriteLine("Digite um número para descobrir seu fatorial: ");
    num = int.Parse(Console.ReadLine());

    for (i = 1; i <= num; i = i + 1)
    {
      total = i * total;
    }

    Console.WriteLine($"O fatorial de {num} é igual a {total}");

  }
}