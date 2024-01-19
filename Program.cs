using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(10,50);

            decimal primeiro_valor;
            decimal segundo_valor;
            decimal terceiro_valor;

            Console.WriteLine("voce tera tres tentativa para acertar o numero sorteado");
            primeiro_valor = decimal.Parse(Console.ReadLine());

            if (primeiro_valor == valorInteiro)
            { Console.WriteLine("o valor esta correto");
            Console.WriteLine("o valor é  =");

             Console.WriteLine("voce possui 3 tentativas para acerta o numero');

        }
    }
}
