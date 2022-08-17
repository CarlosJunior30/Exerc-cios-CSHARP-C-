using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cordernadas_cartesianas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor digite o primeiro numero da cordenada:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, digite o segundo numero da cordenada:");
            int y = int.Parse(Console.ReadLine());

            if (x >= 0 && y >= 0) 
            {
            Console.WriteLine("Faz parte de PRIMEIRO quadrante!");
            }
            else if (x>= 0 && y < 0)
            {
                Console.WriteLine("Faz parte do QUARTO quadrante!");
            }

            else if (x < 0 && y >= 0)
            {
                Console.WriteLine("Faz parte do SEGUNDO quadrante!");
            }
            else
            {
                Console.WriteLine("Faz parte do TERCEIRO quadrante!");
            }
            Console.ReadLine();



        }
    }
}
