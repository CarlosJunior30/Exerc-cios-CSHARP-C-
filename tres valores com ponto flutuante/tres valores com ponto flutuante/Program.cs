using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tres_valores_com_ponto_flutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            
            Console.WriteLine("Informe o primeiro valor:");
            double A = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o primeiro valor:");
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o primeiro valor:");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaTriangulo = (A * C) / 2;
            double AreaCirculoRaioC = (pi * (C * C));
            double AreaTrapezio = (A + B) * C / 2;
            double AreaQuadrado = (B * B);
            double AreaRetangulo = (A * B);

            Console.WriteLine("A area do Triangulo: " + AreaTriangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do Circulo: " + AreaCirculoRaioC.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do Trapezio: " + AreaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do Quadrado: " + AreaQuadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do Retangulo: " + AreaRetangulo.ToString("f3",CultureInfo.InvariantCulture));

            Console.ReadLine();









        }
    }
}
