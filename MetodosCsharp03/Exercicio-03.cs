using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 3: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado Somar que receba dois inteiros como parâmetros e retorne a soma desses dois números. 

namespace MetodosCsharp03
{
    class Exercicio_03
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            int resultado = Soma(5, 5);
            Console.WriteLine($"O resultado da soma é {resultado}");
        }
    }
}
