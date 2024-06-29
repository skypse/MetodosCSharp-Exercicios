using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 17: Método sem Parâmetros com Retorno:
//Descrição: Crie um método chamado GerarNumeroAleatorio que não receba parâmetros e retorne um número inteiro aleatório entre 1 e 100. 

namespace MetodosCsharp17
{
    class Exercicio_17
    {
        public static int GerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        public static void Main(string[] args)
        {
            int numeroAleatorio = GerarNumeroAleatorio();
            Console.WriteLine($"Número aleatório: {numeroAleatorio}");
        }
    }
}
