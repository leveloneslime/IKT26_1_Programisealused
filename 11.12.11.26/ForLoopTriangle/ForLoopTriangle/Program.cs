namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //täisnurkne püramiid for loop
            Console.WriteLine("sisesta rida kogus");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= rows; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
