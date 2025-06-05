using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, contador = 0;

            while (contador < 30)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
                contador++;
            }

        }
    }
}
