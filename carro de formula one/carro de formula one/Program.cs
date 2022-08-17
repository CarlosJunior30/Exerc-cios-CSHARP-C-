using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_de_formula_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidade = 0; 
           while (velocidade < 200)
            {
                Console.WriteLine("o carros esta a " + velocidade + "km");
                Console.WriteLine(velocidade++);
            }
            Console.WriteLine("o carro atingiu o limite da pista!!!");
            Console.ReadLine();






        }
    }
}
