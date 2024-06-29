using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 15: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado ObterMenorNumero que receba três inteiros como parâmetros e retorne o menor entre eles. 

namespace MetodosCsharp15
{
    class Exercicio_15
    {
        public static int ObterMenorNumero(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        public static void Main(string[] args)
        {
            int a = 3, b = 7, c = 1;
            int menor = ObterMenorNumero(a, b, c);
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
