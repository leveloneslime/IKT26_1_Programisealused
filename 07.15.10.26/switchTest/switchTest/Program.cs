namespace switchTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kolm täisarvu ja kuva nende summa.
            //kutsu meetod mis kuvab teksti edukat lahendamist
            //küsi kasutaja lemmik õppeainet

            Console.WriteLine("vali mida sa teed");
            Console.WriteLine("---");
            Console.WriteLine("valikus on:");
            Console.WriteLine("1 = arvude liitmine");
            Console.WriteLine("2 = MA VIHKAN KALKULAATOREID!!");
            Console.WriteLine("3 = sisesta enda lemmik õppeaine");
            int Menu = int.Parse(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    Console.WriteLine("valisid arvude liitmise!");
                    Console.WriteLine("kirjuta number 1");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("kirjuta number 2");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("kirjuta number 3");
                    int num3 = int.Parse(Console.ReadLine());

                    int sum = num1 + num2 + num3;
                    Console.WriteLine("arvude summa on " + sum);
                    break;

                case 2:
                    Solution();
                    break;
                case 3:
                    Console.WriteLine("Sisesta enda lemmik õppeaine");
                    string Subject = Console.ReadLine();
                    Console.WriteLine("Sinu lemmik aine on " + Subject);
                    break;
                default:
                    Console.WriteLine("sisestasid kahtlase arvu");
                    break;
            }
        }

        static void Solution()   
        {
            Console.WriteLine("Edukat lahendamist!");
        }
    }
}
