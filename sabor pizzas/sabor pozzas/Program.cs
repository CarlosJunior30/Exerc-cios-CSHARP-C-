using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabor_pozzas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] saboresDePizza = { "mussarela  ", "calabresa  ", "peperone  ", "4 queijos  ", "banana  ", "bacon  ", "sardinha  ", "fritas  ", "carnes  ", "leite  " };

            foreach (string sabor in saboresDePizza)
            {
              Console.WriteLine(sabor + "temos o sabor" + "||" + "aproveite a refeição");

            }
            Console.ReadLine(); 



        }
    }
}
