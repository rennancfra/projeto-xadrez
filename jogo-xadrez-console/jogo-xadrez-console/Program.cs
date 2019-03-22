using System;
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
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
            /*try
            {

            
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            Tela.imprimirTabuleiro(tab);

            
            }
            catch (TabuleiroException e)
            {

                Console.Write(e.Message);
            }
            Console.ReadKey();*/
        }
    }
}
