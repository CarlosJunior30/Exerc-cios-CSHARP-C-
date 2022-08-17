using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem_regressiva_foguete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contagem = 1000;
           for (contagem = 1000; contagem > 0; contagem--)
                {
                Console.WriteLine("contagem regressiva para lancamento do foguete" + "==" + contagem + "==" + "segundos!");

                 }
            Console.WriteLine("FOGUETE LANÇADO");
           Console.ReadLine();  




        }
    }
}
