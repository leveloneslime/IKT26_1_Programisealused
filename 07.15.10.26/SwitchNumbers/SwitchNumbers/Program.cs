namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta 10, 20 või 30!");
            //tuleb teha switc kus esimene case on 10 teine on 20 ja kolmas on 30


            int numInt = int.Parse(Console.ReadLine());

            switch (numInt)
            {
                case 10:
                    Console.WriteLine("kirjutasid 10!");
                    break;
                case 20:
                    Console.WriteLine("kirjutasid 20!");
                    break;
                case 30:
                    Console.WriteLine("kirjutasid 30!");
                    break;
                default:
                    Console.WriteLine("sisestasid kahtlase muutuja");
                    break;
            }
        }
    }
}
