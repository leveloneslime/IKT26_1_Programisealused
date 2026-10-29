namespace MaaCalculaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //meil om münt mille diameeter on 25.75mm
            //arvutada välja maa ümbermõõt ka mitu münti
            //mahun järjestikku ümber maa
            //arvutuses tohib kasutada ainult mündi diameetrit ja maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000; //mm
            double earthCircumfrance = 2 * 3.14 * earthRadius;

            double howMany = earthCircumfrance / coinDiameter;

            Console.WriteLine("kui münt on " + coinDiameter + "mm, ja maa raaadius on " + earthRadius + " mm siis");
            Console.WriteLine("maa ümber mahub {0:0}", howMany);
        }
    }
}
