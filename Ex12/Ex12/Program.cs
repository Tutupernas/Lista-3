using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            do
            {
                int N;
                do
                {
                    Console.Write("Digite a quantidade de valores (menor que 20): ");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0 || N >= 20)
                        Console.WriteLine("Valor inválido. Digite um número positivo menor que 20.");
                } while (N <= 0 || N >= 20);

                int[] valores = new int[N];
                int soma = 0, positivos = 0, negativos = 0;
                int maior, menor;
                int i = 0;

                while (i < N)
                {
                    Console.Write($"Digite o {i + 1}º valor: ");
                    valores[i] = int.Parse(Console.ReadLine());

                    soma += valores[i];

                    if (valores[i] > 0) positivos++;
                    else if (valores[i] < 0) negativos++;

                    i++;
                }

                maior = valores.Max();
                menor = valores.Min();
                double media = (double)soma / N;
                double percPos = (double)positivos / N * 100;
                double percNeg = (double)negativos / N * 100;

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Maior valor: {maior}");
                Console.WriteLine($"Menor valor: {menor}");
                Console.WriteLine($"Soma dos valores: {soma}");
                Console.WriteLine($"Média aritmética: {media:F2}");
                Console.WriteLine($"Porcentagem de valores positivos: {percPos:F1}%");
                Console.WriteLine($"Porcentagem de valores negativos: {percNeg:F1}%");

                do
                {
                    Console.Write("\nDeseja realizar uma nova execução? (S/N): ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta != "S" && resposta != "N")
                        Console.WriteLine("Resposta inválida. Digite apenas 'S' ou 'N'.");
                } while (resposta != "S" && resposta != "N");

            } while (resposta == "S");

           
        }
    }
}
