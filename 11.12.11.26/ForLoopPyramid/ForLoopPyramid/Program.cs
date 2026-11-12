namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta arv");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int x = i; x <= rows; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }


            for (int i = rows - 1;  i >= 1; i--)
            {
                for (int x = 1; x <= rows - i; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n");
        }
    }
}
