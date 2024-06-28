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
        public static int ObterMenorNumero(int num1, int num2, int num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }

        public static void Main(string[] args)
        {
            int menor = ObterMenorNumero(6, 7, 5);
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
