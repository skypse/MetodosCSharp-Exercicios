using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 4: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado Multiplicar que receba dois inteiros como parâmetros e retorne o produto desses dois números.

namespace MetodosCsharp04
{
    class Exercicio_04
    {
        public static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public static void Main(string[] args)
        {
            int resultado = Multiplicacao(2, 6);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
        }
    }
}
