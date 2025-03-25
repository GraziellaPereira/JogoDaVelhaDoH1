using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaDoH1;
internal class Program
{
    Random rnd = new Random();
    void menuJogo()
    {
        bool executando = true;
        Console.WriteLine("Vamos jogar o Jogo da Velha!");
        Console.WriteLine("Qual vai ser o modo de jogo? Digite uma opção ou saia da aplicação.");
        Console.WriteLine("1 - H x H (Humano vs Humano)");
        Console.WriteLine("2 - H x M (Humano vs Máquina)");
        Console.WriteLine("2 - H x M (Humano vs Máquina)");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                jogo.HxH;
                break;

            case 2:
                jogo.HxM;
                break;

            case 3:
                Console.WriteLine("Encerrando o sistema...");
                executando = false;
                break;

            default:
                Console.WriteLine("Opção inválida! Digite de 1 a 3.");


