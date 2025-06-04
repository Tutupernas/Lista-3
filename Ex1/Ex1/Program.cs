using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do
            {
                Console.Write("Digite um valor positivo: ");
                valor = int.Parse(Console.ReadLine());
            } while (valor <= 0);

        }
    }
}
