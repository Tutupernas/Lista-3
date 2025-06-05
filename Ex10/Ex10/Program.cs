using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];

            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                int valor;
                do
                {
                    Console.Write($"Digite o {i + 1}º valor positivo: ");


                    valor = int.Parse(Console.ReadLine());



                    if (valor <= 0)

                        Console.WriteLine("Valor inválido. Digite um número positivo.");


                } while (valor <= 0);

                valores[i] = valor;


                soma += valor;
            }

            int maior = valores.Max();



            double media = (double)soma / 10;

            Console.WriteLine("\nResultados:");

            Console.WriteLine($"Maior valor: {maior}");

            Console.WriteLine($"Soma dos valores: {soma}");

            Console.WriteLine($"Média aritmética: {media:F2}");

        }
    }
}
