using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDeepTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Detalles detalles = new Detalles() { Color = "Blanco", Raza = "Dogo" };
            Animal animal = new Animal() { Nombre = "Perro", Patas = 2, Detalles = detalles};

            Animal animalClon = animal.Clone() as Animal;
            animalClon.Detalles.Raza = "Doberman";

            Console.WriteLine("-----------------------------");
            Console.WriteLine("CON PROTOTYPE DEEP");
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Original: " + animal.Detalles.Raza);
            Console.WriteLine("Clonado: " + animalClon.Detalles.Raza);


            if (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
