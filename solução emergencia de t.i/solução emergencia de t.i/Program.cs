using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solução_emergencia_de_t.i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int urgencia;
            
            Console.WriteLine("Por favor, descreva a solicitacao: ");
            Console.ReadLine();
            Console.WriteLine("digite a sua urgencia");
            urgencia = int.Parse(Console.ReadLine());

            if (urgencia > 0 & urgencia <= 3)
            {
                Console.WriteLine("CLassificação do chamado:  BAIXO ");
            }
            else if (urgencia > 3 & urgencia <= 6)
            {
                Console.WriteLine("Classificação do chamado : MÈDIO ");
            }
            else if (urgencia > 6 & urgencia <= 9)
            {
                Console.WriteLine("Classificação do chamado: ALTO ");
            }
            else             {
                Console.WriteLine("Classificação do chamado : GRAVE ");
            }
         
                  
            
            
            
            
            Console.ReadLine();
            */

            Console.WriteLine("vamos ver em qyal fase da vida, voce esta? :");

            int idade = int.Parse(Console.ReadLine());

            if (idade >=0 & idade <=11)
                {
                Console.WriteLine("voce é uma criança!");
            }
            else if (idade > 11 & idade <= 17)
            {
                Console.WriteLine("voce é um adolescente!");
            }
            else if (idade > 17 & idade <= 40)
            {
                Console.WriteLine("voce é um adulto!");
             }
            else
            {
                Console.WriteLine("voceé um idoso");
            }

            Console.ReadLine();








        }
    }
}
