using System;
namespace ElisProjectNew
{


    public class Program
    {
        static int maxNum = 10;

        public static void Main()
        {
            Console.WriteLine("Hi Eli!");

            Console.WriteLine("Please enter the first number:");
            var num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            var num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Math.Add(num1, num2));


            var input = Console.ReadLine();
        }



        public Program()
        {
            Console.WriteLine("Hi Eli!");
            //Console.WriteLine(input);
        }
    }

    public static class Math
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
