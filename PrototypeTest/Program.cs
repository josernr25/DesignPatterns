using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeShallowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Nombre = "Perro", Patas = 2 };

            Animal animalClon = animal;
            animalClon.Nombre = "Gato";

            Console.WriteLine("-----------------------------");
            Console.WriteLine("SIN PROTOTYPE");
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Original: "+animal.Nombre);
            Console.WriteLine("Clonado: " + animalClon.Nombre);

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("CON PROTOTYPE");
            Console.WriteLine("-----------------------------\n");

            animal.Nombre = "Perro";
            animalClon = animal.Clone() as Animal;
            animalClon.Nombre = "Gato";

            Console.WriteLine("Original: "+animal.Nombre);
            Console.WriteLine("Clonado: " + animalClon.Nombre);

            if (Console.ReadKey().Key != ConsoleKey.Escape){}
        }
    }
}
