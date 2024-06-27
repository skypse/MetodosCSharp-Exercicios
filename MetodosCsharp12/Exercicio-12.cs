using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 12: Método com Parâmetro sem Retorno:
//Descrição: Crie um método chamado ImprimirQuadrado que receba um inteiro como parâmetro e imprima o quadrado desse número. 

namespace MetodosCsharp12
{
    class Exercicio_12
    {
        public static void ImprimirQuadrado(int numero)
        {
            Console.WriteLine(numero * numero);
        }

        public static void Main(string[] args)
        {
            ImprimirQuadrado(4);
        }
    }
}
