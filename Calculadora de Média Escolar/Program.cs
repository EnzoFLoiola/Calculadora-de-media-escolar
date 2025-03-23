using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Média_Escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop_enquanto = true;
            while (loop_enquanto)
            {
                Console.Write("Digite o nome do Aluno: ");
                String Nome_Aluno = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de notas do aluno: ");
                int Quantidade_de_Notas = int.Parse(Console.ReadLine());

                float[] Array_Notas = new float[Quantidade_de_Notas];

                for (int i = 0; i < Quantidade_de_Notas; i++)
                {
                    float nota;
                    do
                    {
                        Console.Write($"Digite a {i + 1}ª nota (entre 0 e 10): ");
                        nota = float.Parse(Console.ReadLine());
                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("Nota inválida! Digite um valor entre 0 e 10.");
                        }
                    } while (nota < 0 || nota > 10);

                    Array_Notas[i] = nota;
                }

                float auxiliar_media = 0.0f;

                foreach (float nota in Array_Notas)
                {
                    auxiliar_media += nota;
                }

                float media_final = auxiliar_media / Quantidade_de_Notas;

                if (media_final >= 7)
                {
                    Console.WriteLine($"O Aluno {Nome_Aluno} está aprovado com a média {media_final:F2}");
                }
                else if (media_final >= 5 && media_final < 7)
                {
                    Console.WriteLine($"O Aluno {Nome_Aluno} está em recuperação com a média {media_final:F2}");
                }

                else
                {
                    Console.WriteLine($"O Aluno {Nome_Aluno} está reprovado com a média {media_final:F2}");
                }

                Console.WriteLine("\nDeseja continuar o programa? ");
                Console.WriteLine("Digite 1 para continuar ou qualquer outra tecla para sair.\n");

                if (Console.ReadLine() != "1")
                {
                    loop_enquanto = false;
                }

            }

        }

    }
}
