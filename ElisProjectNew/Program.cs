using System;
namespace ElisProjectNew
{


    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Give me two real numbers and I will add, subtract, multiply and divide them!");
            Console.WriteLine();
            Console.WriteLine("Please enter the first number and press enter:");
            var num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the second number and press enter:");
            var num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The sum of those two numbers is "); Console.Write(Math.Add(num1, num2));
            Console.WriteLine(); Console.WriteLine();
            Console.Write("The difference between those two numbers is "); Console.Write(Math.Sub(num1, num2));
            Console.WriteLine(); Console.WriteLine();
            Console.Write("The product of those two numbers is "); Console.Write(Math.Mul(num1, num2));
            Console.WriteLine(); Console.WriteLine();
            Console.Write("The quotient of those two numbers, rounded to the nearest ten-octillionth, is "); Console.Write(Math.Div(num1, num2));
            var input = Console.ReadLine();
        }

    }

    public static class Math
    {
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Sub(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Mul(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal Div(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
