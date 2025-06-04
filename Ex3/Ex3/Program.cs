using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            do
            {
                Console.WriteLine("Digite o sexo (F para feminino, M para masculino): ");
                sexo = char.ToUpper(Console.ReadLine()[0]);

                if (sexo != 'F' && sexo != 'M')
                {
                    Console.WriteLine("Entrada inválida. Digite apenas F ou M.");
                }

            } while (sexo != 'F' && sexo != 'M');

            Console.WriteLine("Sexo informado corretamente: " + sexo);


        }
    }
}
