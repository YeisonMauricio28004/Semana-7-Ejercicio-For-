using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        int altura;

        Console.Write("Introduce la altura del triángulo: ");
        altura = int.Parse(Console.ReadLine());

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}


