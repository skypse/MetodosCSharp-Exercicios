using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 16: Método com Parâmetros e Retorno:
//Descrição: Crie um método chamado EhPrimo que receba um inteiro como parâmetro e retorne verdadeiro se o número for primo e falso caso contrário. 

namespace MetodosCsharp16
{
    class Exercicio_16
    {
        public static bool EhPrimo(int numero)
        {
            if (numero <= 1) 
                return false;
            // verificar divisores de 2 até a raiz quadrada do número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                // se encontrar, número não é primo!
                if (numero % i == 0) 
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            int[] numeros = { 2, 3, 4, 5, 16, 17};

            foreach (int numero in numeros)
            {
                bool resultado = EhPrimo(numero);
                Console.WriteLine($"O número {numero} é primo? {resultado}");
            }
        }
    }
}
