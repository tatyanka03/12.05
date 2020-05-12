using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12._05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { };
            while (true)
            {
                Console.WriteLine("Введите имя ");
                string name = Console.ReadLine();

                names.Add(name);

                Console.WriteLine("Нажмите 1 чтобы продолжить 2 чтобы выйти");

                if (Console.ReadLine() == "2")
                { break; }

            }
            names.Sort();
            names = names.Distinct().ToList();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" Всего имен" + names.Count);

            Console.ReadLine();
                
        }
    }
}
