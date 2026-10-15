namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta number");
            //Esimese koondtulemust puhul on number vahemikus
            //0 kuni 100
            //teises 101 kuni 200 ja
            //kolmandas 201 kuni 300
            int NumInt = int.Parse(Console.ReadLine());
            switch (NumInt)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("kirjutasid 0 kuni 100!");
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("arv on 101 ja 200 vahel!");
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("arv on 201 kuni 300");
                    break;
                default:
                    Console.WriteLine("sisestasid kahtlase arvu");
                    break;
            }

        }
    }
}
