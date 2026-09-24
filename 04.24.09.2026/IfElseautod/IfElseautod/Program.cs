namespace IfElseautod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage oma automark");
            //kasuta if else
            //kirjuta automark
            //kalikus on BMW, Audi, Porsche, Fiat ja skoda
            //kui valitakse skoda, siis seal sees on uuesti küsimus, et
            //miss mudel soovid valida. mudeli valikus on Kodiaq ja Octavia

            string auto = Console.ReadLine();


            if (auto == "BMW")
            {
                Console.WriteLine("auto on bmw");
            }
            else if (auto == "audi")
            {
                Console.WriteLine("auto on audi");
            }
            else if (auto == "porsche")
            {
                Console.WriteLine("auto on porsche");
            }
            else if (auto == "fiat")
            {
                Console.WriteLine("auto on fiat");
            }
            else if (auto == "skoda")
            {
                Console.WriteLine("Palun vali auto mudel");

                string mudel = Console.ReadLine();
                if (mudel == "kodiaq")
                {
                    Console.WriteLine("teie auto on skoda kodiaq");
                }
                else if (mudel == "octavia")
                {
                    Console.WriteLine("teie auto on skoda Octavia");
                }
                else
                {
                    Console.WriteLine("kahtlane mudel");
                }
            }
            else
            {
                Console.WriteLine("kahtlane auto");
            }

        }
    }
}
