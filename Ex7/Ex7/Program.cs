using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero <= 20; numero++)
            {
                Console.WriteLine($"\nTabuada do {numero}:");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.WriteLine("\nPressione qualquer tecla para ver a próxima tabuada...");
                Console.ReadKey();
            }

        }
    }
}
