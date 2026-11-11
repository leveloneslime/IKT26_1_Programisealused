namespace ForKillkoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eelnevaid teadmisi kasutades kirjjuta programm, miss väljustab
            //kill - koll
            //kill - koll
            //killadi -koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //for loopi sees peab olema for loop
            //peab saama sisestada arvu mitu korda väljustada

            Console.WriteLine("sisesta mitu korda korrata");
            int many = int.Parse(Console.ReadLine());

            for (int a = 0; a <= many; a++)
            {
                Console.WriteLine("see on rida nr {0}", a);
                for (int b = 0 ; b < 2; b++)
                {
                    Console.WriteLine("kill - koll ");
                }
                Console.WriteLine("killadi - koll ");
            }
        }
    }
}
