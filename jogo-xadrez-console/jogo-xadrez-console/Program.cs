﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace jogo_xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);



            Console.ReadKey();
        }
    }
}
