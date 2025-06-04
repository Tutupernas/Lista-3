using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            do
            {
                Console.WriteLine("Digite um número positivo: ");
                numero = double.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite somente valores positivos.");
                }

            } while (numero <= 0);

            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }


        }
    }
}
