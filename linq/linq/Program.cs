using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace linq
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collecition)
        {
            Console.WriteLine(message);
            foreach (T obj in collecition)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> product = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name = "Tv", Price = 1700.0, Category = c3 },
                new Product(){Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product(){Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product(){Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product(){Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product(){Id = 9, Name = "Macbook", Price = 1800.0, Category = c2 },
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product(){Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = product.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and price < 900: ", r1);

            var r2 = product.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names od products from tools", r2);

            var r3 = product.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Name Started with 'C'O ans Object Anonymous", r3);

            var r4 = product.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier order for by price then by name:", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price then by name skip 2 take 4", r5);


            // FirstorDefault ( um resultado ou vazio)
            var r6 = product.FirstOrDefault();
            Console.WriteLine("First  or dedault test1  " + r6);

            var r7 = product.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test 2   " + r7);

            var r8 = product.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1 " + r8);

            var r9 = product.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2 " + r9);


        }
    }
}
