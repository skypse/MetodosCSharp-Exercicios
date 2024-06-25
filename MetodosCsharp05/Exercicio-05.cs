using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 5: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado MaiorNumero que receba dois inteiros como parâmetros e retorne o maior entre eles. 

namespace MetodosCsharp05
{
    class Exercicio_05
    {
        public static int MaiorNumero (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static void Main(string[] args)
        {
            int maior = MaiorNumero(2, 4);
            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}
