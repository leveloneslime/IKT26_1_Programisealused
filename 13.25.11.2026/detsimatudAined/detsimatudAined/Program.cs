namespace detsimatudAined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decimal to binary");

            Console.WriteLine("sisesta number");

            int decimalNumber = Convert.ToInt32(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);

        }
    }
}
