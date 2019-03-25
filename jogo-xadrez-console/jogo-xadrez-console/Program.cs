﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez;

namespace jogo_xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();*/
            try
            {


                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {


                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);

                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDestino(origem, destino);

                        partida.executaMovimento(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                Tela.imprimirTabuleiro(partida.tab);


            }
            catch (TabuleiroException e)
            {

                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
