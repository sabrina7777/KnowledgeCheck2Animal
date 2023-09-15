using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var cat = new Cat();

                Console.WriteLine("Enter the kind of the animal (cat, dog, or fish)");
                cat.Kind = Console.ReadLine();

                Console.WriteLine("Enter the color of the animal");
                cat.Color = Console.ReadLine();

                Console.WriteLine("Enter the greeting of the animal");
                cat.Greeting = Console.ReadLine();

                Console.WriteLine("Enter the name of the animal");
                cat.Name = Console.ReadLine();

                recordList.Add(cat);
            }
            // Print out the list of records using Console.WriteLine();
            foreach(var cat in recordList)
            {
                Console.WriteLine("Entry Info Below:");
                Console.WriteLine("Kind is " + cat.Kind);
                Console.WriteLine("Color is " + cat.Color);
                Console.WriteLine("Greeting is " + cat.Greeting);
                Console.WriteLine("Name is " + cat.Name + '\n');
            }
            Console.WriteLine("But ya'll, my cat is the coolest.");
        }
    }
}