using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diretora
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] alunonovo = { "andre", "bianca", "barbara", "carlos", "felipe", "gabriel", "mayara", "michelle", "paulo", "rodrigo" };

            foreach (string BemVindos in alunonovo)
            {
                Console.WriteLine("sejam todos bem vindos, novos alunos " + BemVindos);


            }

            Console.ReadLine();
        }
    }
}
