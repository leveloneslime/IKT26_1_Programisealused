namespace SwitchMisgi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            Console.WriteLine("-----");
            //tee kolm meetodit miss teevad järgmist
            //1. ütleb auh
            //2. ütleb et tahab magada
            //3. ütleb et tahab õppida
            //kutsuda numbri valikuga
            //tuleb kasutada switchi
            //tuleb teha menüü kus kasutaja saab valida millist meetodit üleskutsuda
            Console.WriteLine("vali meetod 1-3");
            Console.WriteLine("1. auh");
            Console.WriteLine("2. tahan magada");
            Console.WriteLine("3. tahan õppida");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Method1();
                    break;
                case 2:
                    Method2();
                    break;
                case 3:
                    Method3();
                    break;
                default:
                    Console.WriteLine("kahtlane meetod");
                    break;
            }
        }
        static void Method1()
        {
            Console.WriteLine("auh");
        }
        static void Method2()
        {
            Console.WriteLine("tahan magada...");
        }
        static void Method3()
        {
            Console.WriteLine("Tahan õppida!!");
        }
    }
}
