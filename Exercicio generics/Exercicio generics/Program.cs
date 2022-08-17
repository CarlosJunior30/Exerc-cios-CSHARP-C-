using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                a.Add(cod);
            }

            Console.Write("how many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                b.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                c.Add(cod);
            }

            HashSet<int> todos = new HashSet<int>(a);
            todos.UnionWith(b);
            todos.UnionWith(c);
            Console.WriteLine("Total students " + todos.Count);





        }
    }
}
