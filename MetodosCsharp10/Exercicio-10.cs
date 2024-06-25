using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 10: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado CalcularMedia que receba três números decimais como parâmetros e retorne a média desses números. 

namespace MetodosCsharp10
{
    class Exercicio_10
    {
        public static decimal CalcularMedia(decimal numero1, decimal numero2, decimal numero3)
        {
            return (numero1 + numero2 + numero3) / 3;
        }

        public static void Main(string[] args)
        {
            decimal media = CalcularMedia(5.5m, 6.5m, 7.5m);
            media = Math.Round(media, 2);
            Console.WriteLine($"A média é: {media}");
        }
    }
}
