namespace IfElseWholeEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll
            //kas on paaris või paaritu

            Console.WriteLine("kirjuta number");

            string number = Console.ReadLine();
            int numberInt = int.Parse(number);

            if (numberInt%2 == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }

        }
    }
}