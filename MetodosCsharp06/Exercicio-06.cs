using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 6: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado EhPar que receba um inteiro como parâmetro e retorne verdadeiro se o número for par e falso se for ímpar. 

namespace MetodosCsharp06
{
    class Exercicio_06
    {
        public static bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }

        public static void Main(string[] args)
        {
            bool resultado = EhPar(4); // verdade
            Console.WriteLine($"O número é par?: {resultado}");
        }
    }
}
