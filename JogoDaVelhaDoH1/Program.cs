using System;
using JogoDaVelhaDoH1Metodos;

namespace JogoDaVelhaDoH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool executandoMenu = true;

            while (executandoMenu)
            {
                Console.Clear();
                Console.WriteLine("Vamos jogar o Jogo da Velha!");
                Console.WriteLine("Qual vai ser o modo de jogo?");
                Console.WriteLine("1 - H x H (Humano vs Humano)");
                Console.WriteLine("2 - H x M (Humano vs Máquina)");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    int opcao = int.Parse(input);
                    JogoDaVelha jogo = new JogoDaVelha();
                    jogo.jogadorAtual = jogo.jogadorX;

                    switch (opcao)
                    {
                        case 1:
                            jogo.HxH();
                            break;

                        case 2:
                            jogo.HxM();
                            break;

                        case 3:
                            Console.WriteLine("Encerrando o sistema...");
                            executandoMenu = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Digite de 1 a 3.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Pressione uma tecla para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
    }
}
