using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 7: Método sem Parâmetros com Retorno:
//Descrição: Crie um método chamado ObterDataAtual que não receba parâmetros e retorne a data atual como uma string no formato "dd/MM/yyyy". 

namespace MetodosCsharp07
{
    class Exercicio_07
    {
        public static string ObterDataAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public static void Main(string[] args)
        {
            string dataAtual = ObterDataAtual();
            Console.WriteLine($"A data de hoje é: {dataAtual}");
        }
    }
}
