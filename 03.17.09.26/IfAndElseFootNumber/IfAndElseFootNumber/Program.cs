using System.ComponentModel;

namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha jalanumbri suurusest üks if ja else harjutuse
            //esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline)
            //teine jalanumber 34 - 38 (siin on tekst valge)
            //kolmas jalanumber 39 - 44 (siin on tekst sinini ja tagataust kollane)
            //eljas jalanumbrid 45 - 48 (siin teeb arvuti häält biip)
            //kindlasti tuleb ära kahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit

            string number = Console.ReadLine();
            int numberInt = int.Parse(number);

            if (numberInt >= 30 && numberInt <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("jalanumber on 30 - 33");
            }
            else if (numberInt >= 34 && numberInt <= 38)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("jalanumber on 34 - 38");
            }
            else if (numberInt >= 39 && numberInt <= 44)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("jalanumber on 39 kuni 44");
            }
            else if (numberInt >= 45 && numberInt <= 48)
            {
                Console.Beep(5000, 1000);
                Console.WriteLine("sinu jalanumber on väga suur");
            }
            else
            {
                Console.WriteLine("jalanumber on kahtlane muutuja");
            }
        }
    }
}
