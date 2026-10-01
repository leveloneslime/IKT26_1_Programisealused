namespace IfElseFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta nimi");
            string name = Console.ReadLine();

            if (name == "mati")
            {
                Console.WriteLine("tere Mati");
            }
            else
            {
                Console.WriteLine("sina ei ole Mati, vaid hoopis" + name);
            }
        }
    }
}
