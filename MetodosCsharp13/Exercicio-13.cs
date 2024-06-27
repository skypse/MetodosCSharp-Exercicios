using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 13: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado CalcularAreaRetangulo que receba a largura e a altura de um retângulo como parâmetros e retorne a área desse retângulo.

namespace MetodosCsharp13
{
    class Exercicio_13
    {
        public static double CalcularAreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }

        public static void Main(string[] args)
        {
            double area = CalcularAreaRetangulo(10.0, 15.0);
            Console.WriteLine($"Área do retângulo: {area}");
        }
    }
}
