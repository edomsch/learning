using System;
namespace ElisProjectNew
{


    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Give me two integers and I will add, subtract, multiply and divide them!");

            Console.WriteLine("Please enter the first number and press enter:");
            var num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number and press enter:");
            var num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The sum of those two numbers is"); Console.WriteLine(Math.Add(num1, num2));
            Console.WriteLine("The difference between those two numbers is"); Console.WriteLine(Math.Sub(num1, num2));
            Console.WriteLine("The product of those two numbers is"); Console.WriteLine(Math.Mul(num1, num2));
            Console.WriteLine("The quotient of those two numbers, truncated at the ones place, is"); Console.WriteLine(Math.Div(num1, num2));
            var input = Console.ReadLine();
        }



        public Program()
        {
           
        }
    }

    public static class Math
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
