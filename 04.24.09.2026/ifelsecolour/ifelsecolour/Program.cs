namespace ifelsecolour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali värv!");
            //Teha if ja else konsoolirakendus, kus
            //kontrollitakse stringi abil värvi vastavust
            //värvide valikuks on: red, blue, green, white
            //Peab käsitlema juhtust, kus vastaja ei sisesta
            //eelpool sisestatud värvi

            string colour = Console.ReadLine();

            //kirjuta konsooli tekst ja vajuta enter
            //Kui ife ja else, esimene kontroll on if
            //järgneb else if iga, viimane on else
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
