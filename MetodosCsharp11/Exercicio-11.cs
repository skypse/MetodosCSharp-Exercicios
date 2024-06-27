using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercício 11: Método sem Parâmetros e sem Retorno:
//Descrição: Crie um método chamado ExibirHoraAtual que não receba parâmetros e apenas imprima a hora atual no formato "HH:mm" na tela.

namespace MetodosCsharp11
{
    class Exercicio_11
    {
        public static void ExibirHoraAtual()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        public static void Main(string[] args)
        {
            ExibirHoraAtual();
        }
    }
}
