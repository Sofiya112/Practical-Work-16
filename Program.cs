using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            ArrayList collection = new ArrayList();
            collection.Add(24);
            collection.Add("Hello, World!");
            collection.Add(true);
            collection.Add(1.16);
            Output(collection);
            collection.RemoveAT(2);

        }
        static void Output(ArrayList collection)
        {
            foreach (var el in collection)
            {
                Console.WriteLine(el);
            }
            {
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    }

