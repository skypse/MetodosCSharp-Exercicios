using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 14: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado CalcularPerimetroCirculo que receba o raio de um círculo como parâmetro e retorne o perímetro do círculo

namespace MetodosCsharp14
{
    class Exercicio_14
    {
        public static double CalcularPerimetroCirculo(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public static void Main(string[] args)
        {
            double perimetro = CalcularPerimetroCirculo(4.0);
            Console.WriteLine($"Perímetro do círculo: {perimetro}");
        }
    }
}
