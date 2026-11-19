using System.ComponentModel.Design;

namespace ForRockPaperSci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string playerChoice = " ";
            int playerPoints = 0;
            int computerPoints = 0;

            while (playerChoice != "lõpeta")
            {
                Console.WriteLine("vali: kivi, paber, käärid");
                Console.WriteLine("mängu lõpetamiseks kirjuta lõpeta");
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "lõpeta")
                {
                    break;

                }

                if (playerChoice != "kivi" &&
                    playerChoice != "paber" &&
                    playerChoice != "käärid")
                {
                    Console.WriteLine("sellist balikut pole, proovi uuesti.");
                    continue;
                }
                
                int computerNumber = random.Next(1, 4); ;
                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "kivi";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "paber";
                }
                else
                {
                    computerChoice = "käärid";
                }
                Console.WriteLine($"Arvuti valis: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("viik");
                }
                else if ((playerChoice != "kivi" && computerChoice == "käärid") ||
                        (playerChoice != "paber" && computerChoice == "kivi") ||
                        (playerChoice != "käärid" && computerChoice == "paber"));
                {
                    Console.WriteLine("sina võitsid!");
                    playerPoints++;
                }

                else
                {
                    Console.WriteLine("kaotasid");
                    computerPoints++;
                }
                Console.WriteLine($"punktid: sina {playerPoints} -- arvuti: {computerPoints}");
            }
        }
    }
}
