using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 9: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado ConcatenarStrings que receba duas strings como parâmetros e retorne a concatenação dessas duas strings. 

namespace MetodosCsharp09
{
    class Exercicio_09
    {
        public static string ConcatenarStrings(string string1, string string2)
        {
            return string1 + string2;
        }

        public static void Main()
        {
            string resultado = ConcatenarStrings("Testando, ", "Concatenação!");
            Console.WriteLine($"Resultado da concatenação: {resultado}");
        }
    }
}
