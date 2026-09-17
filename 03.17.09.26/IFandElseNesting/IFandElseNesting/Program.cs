namespace IFandElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("üks if ja lese nestimine iseseisval");
            Console.WriteLine("teise else if-i sisse panna if/else nestimine");
            //konsool küsib numbrit
            //if = 12
            //else if ja siia sisse osakord teha if neig else. else if tingimus on, et
            //muutuja on suurem kui 20
            //else ja seal väljastab konsool tekstiÖ mingid kahtlased väärtused

            

            string number = Console.ReadLine();
            //muudame string int tüübiks ja kasutame parset
            int numberInt = int.Parse(number);

        // consool loeb string andmetüüpe

            if (numberInt == 12)
            {
                Console.WriteLine("number on 12");
            }
            else if (numberInt > 20)
            {
                if (numberInt > 20)
                {
                    Console.WriteLine("number on suurem kui 20");
                }
                else
                {
                    Console.WriteLine("number on väiksem kui 20");
                }
            }
            else
            {
                Console.WriteLine("numbril on kahtlased väärtused");
            }
            





        }
    }
}