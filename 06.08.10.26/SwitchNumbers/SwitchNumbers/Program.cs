namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta number");
            int numInt = int.Parse(Console.ReadLine());

            switch (numInt)
            {
                case 1:
                    Console.WriteLine("sisestasid 1");
                    break;
                case 2:
                    Console.WriteLine("sisestasid 2");
                    break;
                case 3:
                    Console.WriteLine("sisestasid 3");
                    break;
                default:
                    Console.WriteLine("sisestasid kahtlase numbri");
                    break;
            }
        }
    }
}
