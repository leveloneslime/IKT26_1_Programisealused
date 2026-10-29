namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            //tuleb kasutada while ja omaorda while while sisse panna
            //whil kordab ennast 5 korda

            int x = 1;
            int y = 2;

            while (x < 4)
            {
                Console.WriteLine("loop " + x);
                x++;

                    while (y < 4)
                {
                    Console.WriteLine("nested loop " + y);
                    y++;
                }
            }

        }
    }
}
