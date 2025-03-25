using System;

namespace JogoDaVelhaDoH1Metodos
{
    public class JogoDaVelha
    {
        public string[,] tabuleiro;
        public string jogadorO = "O";
        public string jogadorX = "X";
        public string jogadorAtual;

        public void HxH()
        {
            tabuleiro = new string[3, 3]; // Reinicia o tabuleiro
            bool fimDeJogo = false;

            while (!fimDeJogo)
            {
                Console.Clear();
                ImprimirTabuleiro();
                Console.WriteLine($"Jogador atual: {jogadorAtual}");
                Console.Write("Digite a linha (1 a 3): ");
                int linha = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.Write("Digite a coluna (1 a 3): ");
                int coluna = Convert.ToInt32(Console.ReadLine()) - 1;

                if (tabuleiro[linha, coluna] == null)
                {
                    tabuleiro[linha, coluna] = jogadorAtual;

                    if (VerificarVitoria())
                    {
                        Console.Clear();
                        ImprimirTabuleiro();
                        Console.WriteLine($"Vitória do jogador {jogadorAtual}!");
                        fimDeJogo = true;
                    }
                    else if (VerificarVelha())
                    {
                        Console.Clear();
                        ImprimirTabuleiro();
                        Console.WriteLine("Deu velha!");
                        fimDeJogo = true;
                    }
                    else
                    {
                        jogadorAtual = (jogadorAtual == jogadorX) ? jogadorO : jogadorX;
                    }
                }
                else
                {
                    Console.WriteLine("Posição ocupada! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public void HxM()
        {
            tabuleiro = new string[3, 3]; // Reinicia o tabuleiro
            bool fimDeJogo = false;
            Random rnd = new Random();

            while (!fimDeJogo)
            {
                Console.Clear();
                ImprimirTabuleiro();

                int linha, coluna;

                if (jogadorAtual == jogadorX)
                {
                    Console.WriteLine("Sua vez de jogar!");
                    Console.Write("Digite a linha (1 a 3): ");
                    linha = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.Write("Digite a coluna (1 a 3): ");
                    coluna = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                else
                {
                    Console.WriteLine("Vez do computador...");
                    Console.ReadKey();
                    do
                    {
                        linha = rnd.Next(0, 3);
                        coluna = rnd.Next(0, 3);
                    } while (tabuleiro[linha, coluna] != null);
                }

                if (tabuleiro[linha, coluna] == null)
                {
                    tabuleiro[linha, coluna] = jogadorAtual;

                    if (VerificarVitoria())
                    {
                        Console.Clear();
                        ImprimirTabuleiro();
                        Console.WriteLine($"Vitória do jogador {jogadorAtual}!");
                        fimDeJogo = true;
                    }
                    else if (VerificarVelha())
                    {
                        Console.Clear();
                        ImprimirTabuleiro();
                        Console.WriteLine("Deu velha!");
                        fimDeJogo = true;
                    }
                    else
                    {
                        jogadorAtual = (jogadorAtual == jogadorX) ? jogadorO : jogadorX;
                    }
                }
                else
                {
                    Console.WriteLine("Posição ocupada! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private bool VerificarVitoria()
        {
            return (
                (tabuleiro[0, 0] == jogadorAtual && tabuleiro[0, 1] == jogadorAtual && tabuleiro[0, 2] == jogadorAtual) ||
                (tabuleiro[1, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[1, 2] == jogadorAtual) ||
                (tabuleiro[2, 0] == jogadorAtual && tabuleiro[2, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual) ||

                (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 0] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual) ||
                (tabuleiro[0, 1] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 1] == jogadorAtual) ||
                (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 2] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual) ||

                (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual) ||
                (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual)
            );
        }

        private bool VerificarVelha()
        {
            foreach (var pos in tabuleiro)
            {
                if (pos == null)
                    return false;
            }
            return true;
        }

        private void ImprimirTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string valor = tabuleiro[i, j] ?? " ";
                    Console.Write($" {valor} ");
                    if (j < 2)
                        Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2)
                    Console.WriteLine("---+---+---");
            }
        }
    }
}
