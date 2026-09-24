namespace IfElseMethodCall
{
    internal class Program
    {
        //main on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.WriteLine("vali meetod mida kasutad");
            string Method = Console.ReadLine();
            if (Method == "HelloMethod")
            {
                //kui kirjutad meetodi nime siis seda nimetatakse
                //meetodi kutsumiseks 
                HelloMethod();
            }
            else
            {
                Console.WriteLine("kahtlane meetod");
            }
        }

        //teha teine meetod siia ja nimeks sellel HelloMethod

        static void HelloMethod()
        {
            Console.WriteLine("Hello World!!!");
        }
    }
}
