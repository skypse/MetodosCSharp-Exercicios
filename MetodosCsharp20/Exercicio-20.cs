using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 20: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado CalcularHipotenusa que receba os comprimentos dos dois catetos de um triângulo retângulo como parâmetros e retorne a hipotenusa.


namespace MetodosCsharp20
{
    class Exercicio_20
    {
        public static double CalcularHipotenusa(double cateto1, double cateto2)
        {
            return Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
        }

        public static void Main(string[] args)
        {
            double cateto1 = 3.0;
            double cateto2 = 4.0;
            double hipotenusa = CalcularHipotenusa(cateto1, cateto2);
            Console.WriteLine($"Hipotenusa: {hipotenusa}");
        }
    }
}
