using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Patron de Diseño  de creacion

            Console.WriteLine("Singleton: " + SingletonObject.Instance.inicializacion);
            Console.WriteLine("\nNormal: " + NormalObject.Instance.inicializacion);
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Enter para continuar o ESC para salir.");
            Console.WriteLine("-----------------------------\n");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Singleton: " + SingletonObject.Instance.inicializacion);
                Console.WriteLine("\nNormal: " + NormalObject.Instance.inicializacion);
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Enter para continuar o ESC para salir.");
                Console.WriteLine("-----------------------------\n");
            }


        }
    }
}
