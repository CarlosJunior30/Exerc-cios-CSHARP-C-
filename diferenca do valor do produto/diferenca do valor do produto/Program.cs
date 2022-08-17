using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diferenca_do_valor_do_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            int Diferenca = (A * B) - (C * D);

            Console.WriteLine("A diferença dos produtos é: " + Diferenca);

            Console.ReadLine();


        }
    }
}
