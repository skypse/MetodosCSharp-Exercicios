﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Exercício 1: Método sem Parâmetros e sem Retorno 
// Descrição: Crie um método chamado "ImprimirSaudacao" que não receba parâmetros e apenas imprima "Olá, bem-vindo ao curso de C#!" na tela.

namespace MetodosCsharp01
{
    class Exercicio_01
    {
        public static void ImprimirSaudacao()
        {
            Console.WriteLine("Olá, bem-vindo ao curso de C#!");
        }

        public static void Main(string[] args)
        {
            ImprimirSaudacao();
        }
    }
}
