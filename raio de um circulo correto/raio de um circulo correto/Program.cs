using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace raio_de_um_circulo_correto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double pi = 3.1416;

            Console.WriteLine( "Favor informe o valor do raio: ");
            double EntradaRaio = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture );

            double Area =  pi * (EntradaRaio * EntradaRaio);

            Console.WriteLine("o valor da area do circulo é = " + Area.ToString("F4",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
