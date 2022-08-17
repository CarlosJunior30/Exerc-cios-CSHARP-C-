using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplou_ou_nao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, insira o primeiro numero:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, insira o segundo numero:");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0)
            {
                Console.WriteLine("Esses numeros sao MULTIPLO");

            }
            else
            {
                Console.WriteLine("Esses numeros NÃO SÃO MULTIPLOS");
            }

            Console.ReadLine();



        }
    }
}
