using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            do
            {
                int numero;

                
                do
                {
                    Console.Write("Digite um número inteiro não negativo para calcular o fatorial: ");
                    bool valido = int.TryParse(Console.ReadLine(), out numero);

                    if (!valido || numero < 0)
                    {
                        Console.WriteLine("Valor inválido! Por favor, digite um número inteiro não negativo.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                
                long fatorial = 1;
                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"{numero}! = {fatorial}");

                
                do
                {
                    Console.Write("Deseja fazer outro cálculo? (S/N): ");
                    resposta = Console.ReadLine().Trim().ToUpper();

                    if (resposta != "S" && resposta != "N")
                    {
                        Console.WriteLine("Resposta inválida! Digite apenas 'S' para sim ou 'N' para não.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

            } while (resposta == "S");

            Console.WriteLine("Programa finalizado. Obrigado!");
        }
    }
}
