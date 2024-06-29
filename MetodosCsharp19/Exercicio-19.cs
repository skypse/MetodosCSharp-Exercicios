using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 19: Método com Parâmetros e Retorno 
//Descrição: Crie um método chamado InverterString que receba uma string como parâmetro e retorne a string invertida. 

namespace MetodosCsharp19
{
    class Exercicio_19
    {
        public static string InverterString(string texto)
        {
            char[] array = texto.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static void Main(string[] args)
        {
            string texto = " Amaral";
            string invertida = InverterString(texto);
            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}
