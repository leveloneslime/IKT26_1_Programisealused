namespace KujundiCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ruudu sees asub ring, ringi raadius on 3 ühikut
            //leia ja väljasta ekraanile pindala ja ümbermõõt

            double CircleRad = 3; //m
            double CircleDia = CircleRad * 2; ;
            //ruudu pindala on a*a
            double cubeArea = CircleDia * CircleDia;

            double cubeCirc = CircleDia * 4;
            Console.WriteLine("ruudu pindala on " + cubeArea + " ja ümbermõõt " + cubeCirc);



            double circleSurface = Math.PI * (CircleRad * CircleRad);
            double CircleCircumfrance = 2 * Math.PI * CircleRad;


            Console.WriteLine("kui ringi raadius on 3");
            Console.WriteLine("siis ringi:");
            Console.WriteLine("diameeter on {0:0}", CircleDia);
            Console.WriteLine("pindala ruut ühikutes on {0:0}", circleSurface);
            Console.WriteLine("ümbermõõt {0:0}", CircleCircumfrance);
        } 
    }
}
