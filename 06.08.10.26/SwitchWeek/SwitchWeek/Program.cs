namespace SwitchWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nädalapäev");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("täna on esmaspäev");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("täna on teisipäev");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("täna on kolmapäev");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("täna on neljapäev");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("täna on reede");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("täna on laupäev");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("täna on pühapäev");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
