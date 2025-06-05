using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;

            // Solicita X positivo
            do
            {
                Console.WriteLine("Digite o valor para calcular a tabuada:");
                x = int.Parse(Console.ReadLine());

                if (x <= 0)
                    Console.WriteLine("Valor inválido. Digite apenas valores positivos.");

            } while (x <= 0);

            
            Console.WriteLine("Digite o primeiro valor do intervalo:");
            a = int.Parse(Console.ReadLine());

            
            do
            {
                Console.WriteLine("Digite o último valor do intervalo , maior que o primeiro:");
                b = int.Parse(Console.ReadLine());

                if (b <= a)
                    Console.WriteLine("Erro: O valor deve ser maior que o primeiro digitado.");

            } while (b <= a);

            
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(x + " x " + i + " = " + (x * i));
            }


        }
    }
}
