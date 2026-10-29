namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double calculation1 = 3 + 8 / (4 - 2) * 4;

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculation1);

            double calculation2 = 3 + 8 / 4 - 2 * 4;
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculation2);

            double calculation3 = (3 + 8) / (4 - 2) * 4;
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation3);
            //kui tahad komakohta siis on vaja numbri taha .0
            double calculation4 = (3.0 + 8.0) / (4.0 - 2.0) * 4;
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation4);
        }
    }
}
