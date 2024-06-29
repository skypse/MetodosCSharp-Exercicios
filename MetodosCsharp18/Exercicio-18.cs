using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 18: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado ConverterCelsiusParaFahrenheit que receba uma temperatura em graus Celsius como parâmetro e retorne a temperatura em Fahrenheit. 

namespace MetodosCsharp18
{
    class Exercicio_18
    {
        public static double ConverterCelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static void Main(string[] args)
        {
            double celsius = 25.0;
            double fahrenheit = ConverterCelsiusParaFahrenheit(celsius);
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}");
        }
    }
}
