namespace IfElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali värv!");
            
            string colour = Console.ReadLine();

            if (colour == "punane")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("värv on punane");
            }
            else if (colour == "sinine")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("värv on sinine");
            }
            else if (colour == "roheline")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("värv on roheline");
            }
            else if (colour == "valge")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("värv on valge");
            }
            else
            {
                Console.WriteLine("kahtlane värv");
            }


        }
    }
}
