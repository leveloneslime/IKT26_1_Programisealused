namespace SwitchRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("täringu viskamise mäng!!");
            Console.WriteLine("kirjuta veereta et veeretada oma täring!!!");

            string roll = Console.ReadLine();
            if (roll == "veereta")
            {
                //ramdom genereerib iga kord suvalise nr 1 kuni 6
                int cube = new Random().Next(1, 7);
                switch (cube)
                {
                    case 1:
                        Console.WriteLine("said ühe!");
                        break;
                    case 2:
                        Console.WriteLine("said kahe!");
                        break;
                    case 3:
                        Console.WriteLine("Said kolme!");
                        break;
                    case 4:
                        Console.WriteLine("said nelja");
                        break;
                    case 5:
                        Console.WriteLine("said viie!");
                        break;
                    case 6:
                        Console.WriteLine("Said kuue!!");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("mängi täringutega siis hiljem!"); 
            }



        }
    }
}