using System.Reflection.Emit;

namespace SwitchCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                float res;
                Console.WriteLine("Sisesta esimene number:");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("sisesta teine number:");
                float num2 = float.Parse(Console.ReadLine());
        
                Console.WriteLine("sisesta sümbol (+, -, *, /):");
                String symbol = Console.ReadLine();

                //tuleb teha switchi valik kas *, /, +, -
                //tykeb teha  neli casei kus tulemus sovitud tehe
                //peab näitama tulemust
                //kasuta floati persistimisel
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine($"liitimine:" + (num1) + (symbol) + (num2) + "=" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine($"lahutamine:" + (num1) + (symbol) + (num2) + "=" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine($"korrutamine:" + (num1) + (symbol) + (num2) + "=" + res);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            res = num1 / num2;
                            Console.WriteLine($"jagamine:" + (num1) + (symbol) + (num2) + "=" + res);
                        }
                        break;
                    default:
                        Console.WriteLine("Vale sümbol");
                        break;
                }
                Console.ReadLine();
                Console.Write("Kas tahad jätkata(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
