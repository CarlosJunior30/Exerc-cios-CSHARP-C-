using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite primeira nota: ");
            string nota1digitada = Console.ReadLine();
            Double nota1 = Convert.ToDouble(nota1digitada);

            Console.WriteLine("digite segunda nota: ");
            string nota2digitada = Console.ReadLine();
            Double nota2 = Convert.ToDouble(nota2digitada);

            Console.WriteLine("digite terceira nota: ");
            string nota3digitada = Console.ReadLine();
            Double nota3 = Convert.ToDouble(nota3digitada);

            Console.WriteLine("digite quarta nota: ");
            string nota4digitada = Console.ReadLine();
            Double nota4 = Convert.ToDouble(nota4digitada);
           

               
            Double media = (nota1 + nota2 + nota3 + nota4) / 4;
            
                      
            Console.WriteLine("Media Final: " + media);     
        }
    }
}
