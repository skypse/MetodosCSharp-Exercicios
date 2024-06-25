using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 8: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado CalcularFatorial que receba um inteiro positivo como parâmetro e retorne o fatorial desse número. 

namespace MetodosCsharp08
{
    class Exercicio_08
    {
        public static int CalcularFatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * CalcularFatorial(numero - 1);
        }

        public static void Main()
        {
            int numero = 5;
            int fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }
}
