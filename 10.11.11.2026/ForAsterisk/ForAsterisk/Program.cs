namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja prindib vastavalt ridade arvule törne
            //kasuta for loop

            Console.WriteLine("sisesta ridade arv");

            int RowAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < RowAmount; i++)
            {
                Console.WriteLine("*****");
            }
        }
    }
}
