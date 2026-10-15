using System.Net.WebSockets;

namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("multiple cases");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("basics");
                    break;

                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediet");
                    break;

                case "Asynchrpnous programming" or "LINQ" or "Delegates":
                    Console.WriteLine("advanced");
                    break;

                default:
                    Console.WriteLine("Unknowns course");
                    break;
            }

        }
    }
}
