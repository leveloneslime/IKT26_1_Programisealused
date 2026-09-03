namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string e tähemärkide jada, mis on defineeritud andmetüübiga string
            //andetüüp toetab ainult true/false väärtusi
            //myString on muutuja , mis of defineeritud andmetüübina "string"
            //saab sisestada kõike, mis on klaviatuuril
            string myString = "Hello, World1";
            //kitjutage cw + tab, et genereerida Console.Writeline
            Console.WriteLine(myString);
            string one = "1";
            string two = "2";
            Console.WriteLine(one + two);

            Console.WriteLine("-----byte-----");
            //byte on täisarvuline andmetüüp, nis toetab
            //ainult täisarve vahemikus 0 kuni 255  (8 bit)
            byte myByte = 5;
            byte secondByte = 255;
            Console.WriteLine(myByte);
            Console.WriteLine(secondByte);

            Console.WriteLine("-----short-----");
            //short on täisarvuline andmetüüp, mis toetab täisarve (16 bit)
            short myShort = 5;
            short secondShort = 10;
            Console.WriteLine(myShort);
            Console.WriteLine(secondShort);

            Console.WriteLine("-----integer-----");
            //int on täisarvuline andmetüüp, mis toetab ainult täisarve (32 bit)
            int myInt = 5;
            int secondInt = 10;
            Console.WriteLine(myInt);
            Console.WriteLine(secondInt);
            //kui 2 int muutujat liita, siis liidetakse nende väärtused kokku
            Console.WriteLine(myInt + secondInt);

            Console.WriteLine("-----long-----");
            //long on täisarvuline andmetüüp, mis toetab vaid täisarve (64 bit)
            long myLong = 5L;
            long secondLong = 10L;
            Console.WriteLine(myLong);
            Console.WriteLine(secondLong);
            Console.WriteLine(myLong + secondLong);

            Console.WriteLine("-----bool-----");
            //see on andmetüüp mis toetab vaid true/falce väärtuseid
            bool myBool = true;
            bool secondBool = false;
            Console.WriteLine(myBool);
            Console.WriteLine(secondBool);


            Console.WriteLine("-----double-----");
            //double on ujukomaarvuline andmetüüp, miss toetab ujukomaarve
            double myDouble = 5.5;
            double secondDouble = 10;
            Console.WriteLine(myDouble);
            Console.WriteLine(secondDouble);
            //kui kaks double tüüpi muutujat liita, siis liidetakse nende väärtused
            Console.WriteLine(myDouble + secondDouble);

            //float on ujukomaarvuline andmetüüp, mis toetab vaid ujukomaarve
            Console.WriteLine("-----Float-----");
            float myFloat = 5.5f;
            float secondFloat = 10.5f;
            Console.WriteLine(myFloat);
            Console.WriteLine(secondFloat);
            Console.WriteLine(myFloat + secondFloat);

            Console.WriteLine("-----decimal-----");
            //decimal on ujukomaarvuline andmetüüp, mis toetab ainult ujukomaarve
            decimal myDecimal = 5.51m;
            decimal secondDecimal = 10.5m;
            Console.WriteLine(myDecimal);
            Console.WriteLine(secondDecimal);
            Console.WriteLine(myDecimal + secondDecimal);


            

        }
    }
}
