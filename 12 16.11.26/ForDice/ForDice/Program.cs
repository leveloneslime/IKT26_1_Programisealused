namespace ForDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("täringu viskamise mäng!!");
            Console.WriteLine("kirjuta veereta et veeretada oma täring!!!");

            Random random = new Random();
            int playerScore = 0;
            int computerScore = 0;

            for (int round = 0; round < 10; round++)
            {
                Console.WriteLine($"voor {round}. vajuta ender, et täringut veeretada");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);
                Console.WriteLine($"sinu number on {playerRoll}");
                Console.WriteLine($"arvuti number on {computerRoll}");

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("w");
                }
                else if (computerRoll > playerRoll)
                {
                    Console.WriteLine("l");
                }
                else
                {
                    Console.WriteLine("viik");
                }
            }
            Console.WriteLine("mäng läbi");

            if (playerScore > computerScore)
            {
                Console.WriteLine("võitsid");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("kaotus");
            }
            else
            {
                Console.WriteLine("viik");
            }
        }
    }
}
