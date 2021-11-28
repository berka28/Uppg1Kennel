using Kennel.Rental;
using Kennel.Rental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    internal class Application : IApplication
    {
        public IRental Rental { get; set; }

        public Application(IRegularRental rental)
        {
            Rental = rental;
        }

        public void Run()
        {
            var newRental = Rental;
            
            Console.WriteLine("The Kennel Farm Inc.");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Please select  ");
            Console.WriteLine("---------------------");
            Console.WriteLine("F: Finished");
            Console.WriteLine("C: Add Claw cutting");
            Console.WriteLine("W: Add Washing");
            Console.WriteLine("Q: Quit Program");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'f' or 'F':
                        Console.WriteLine($"Your have chosen: {Rental.GetDescription()} the price is {Rental.GetCost()}");
                        Rental = newRental;
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Adding Washing");
                        Rental = new Washing(Rental);
                        break;

                    case 'w' or 'W':
                        Console.WriteLine("Adding Claw cuts");
                        Rental = new ClawCut(Rental);
                        break;

                    case 'q' or 'Q':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:

                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }  
}
