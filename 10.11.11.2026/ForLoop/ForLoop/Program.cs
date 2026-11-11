namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("täisarvude kokku liiitmine kuni kümneni");
            Console.WriteLine("---------");
            Console.WriteLine("");

            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                //sum += j;
                sum = sum + j;
                Console.WriteLine("summa on: " + sum);
            }
        }
    }
}
