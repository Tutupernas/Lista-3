using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiro, segundo;

            Console.WriteLine("Digite o primeiro valor: ");
            primeiro = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o segundo valor (maior que o primeiro): ");
                segundo = int.Parse(Console.ReadLine());

                if (segundo <= primeiro)
                {
                    Console.WriteLine("Erro: o segundo valor deve ser maior que o primeiro!");
                }

            } while (segundo <= primeiro);

            Console.WriteLine("Valores válidos: primeiro = " + primeiro + ", segundo = " + segundo);



        }
    }
}
