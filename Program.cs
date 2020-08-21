using System;

namespace Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor inicial: ");
            int inicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor final: ");
            int final = int.Parse(Console.ReadLine());
            if (inicial < final)
            {
                for (int i = 0; i < final; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Número incial maior que o final");
            }


        }
    }
}
