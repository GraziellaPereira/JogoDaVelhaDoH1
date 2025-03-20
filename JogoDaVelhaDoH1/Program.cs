string[,] tabuleiro = new string[3,3];
string jogadorO = "O";
string jogadorX = "X";
string jogadorAtual = jogadorX;
int linha, coluna;
Random rnd = new Random();

bool fimDeJogo=false;
//fimDeJogo == false
while (!fimDeJogo)
{   if (jogadorAtual == jogadorX)
    {
        Console.WriteLine("Sua vez de jogar!");
        Console.WriteLine("Digite a linha: ");
        linha = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Digite a coluna: ");
        coluna = Convert.ToInt32(Console.ReadLine()) - 1;
    } else
    {
        Console.WriteLine("Vez do computador!");
        Console.ReadKey();
        linha = rnd.Next(0, 3);
        coluna = rnd.Next(0, 3);
    }

    if (tabuleiro[linha, coluna] == null)
    {
        tabuleiro[linha, coluna] = jogadorAtual;
        if( 

            (tabuleiro[0,0] == tabuleiro[0,1] &&
            tabuleiro[0,1] == tabuleiro[0, 2] &&
            tabuleiro[0, 0] != null
            )
            ||
            (tabuleiro[1, 0] == tabuleiro[1, 1] &&
            tabuleiro[1, 1] == tabuleiro[1, 2] &&
            tabuleiro[1, 0] != null
            )
            ||
            (tabuleiro[2, 0] == tabuleiro[2, 1] &&
            tabuleiro[2, 1] == tabuleiro[2, 2] &&
            tabuleiro[2, 0] != null
            )
            ||
            (
                tabuleiro[0, 0] == tabuleiro[1, 0] &&
                tabuleiro[1, 0] == tabuleiro[2, 0] &&
                tabuleiro[0, 0] != null
            )
              ||
            (
                tabuleiro[0, 1] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 1] &&
                tabuleiro[0, 1] != null
            ) ||
            (
                tabuleiro[0, 2] == tabuleiro[1, 2] &&
                tabuleiro[1, 2] == tabuleiro[2, 2] &&
                tabuleiro[0, 2] != null
            ) ||
            (
              tabuleiro[0,0] == tabuleiro[1, 1] &&
              tabuleiro[1,1] == tabuleiro[2, 2] &&
              tabuleiro[0,0] != null
            ) ||
            (
              tabuleiro[2,0] == tabuleiro[1,1] &&
              tabuleiro[1,1] == tabuleiro[0,2] &&
              tabuleiro[2, 0] != null
            )
        )
        {
            Console.WriteLine("Vitória do jogador " 
                + jogadorAtual);
            fimDeJogo = true;
        }
        else
            if
            (
            tabuleiro[0,0] != null &&
            tabuleiro[0,1] != null &&
            tabuleiro[0,2] != null &&
            tabuleiro[1,0] != null &&
            tabuleiro[1,1] != null &&
            tabuleiro[1,2] != null &&
            tabuleiro[2,0] != null &&
            tabuleiro[2,1] != null &&
            tabuleiro[2,2] != null

            )
        {
            Console.WriteLine("Deu velha!");
            fimDeJogo = true;
        }

        if (jogadorAtual == jogadorX)
            jogadorAtual = jogadorO;
        else
            jogadorAtual = jogadorX;
    }
    else
    {
        if (jogadorAtual == jogadorX) {
            Console.WriteLine("Posição está ocupada");
        }

    }
    Console.Clear();
    ImprimirTabuleiro();
}





Console.ReadLine();

void ImprimirTabuleiro()
{
    for (int linhaTabuleiro = 0; linhaTabuleiro < 3; linhaTabuleiro++)
    {
        for(int colunaTabuleiro =  0; colunaTabuleiro < 3; colunaTabuleiro++)
        {
            if (tabuleiro[linhaTabuleiro, colunaTabuleiro] == null)
                Console.Write("   ");
            else
                Console.Write(" " + tabuleiro[linhaTabuleiro, colunaTabuleiro] + " ");
            if(colunaTabuleiro<2)
                Console.Write( " | " );
        }
        Console.WriteLine();
        if(linhaTabuleiro < 2)
            Console.WriteLine("----------------");
 
    }
}