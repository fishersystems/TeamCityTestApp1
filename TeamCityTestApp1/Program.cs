using System;
using TeamCityTestApp1.Tools;

namespace TeamCityTestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            var adder = new Adder();
            Console.WriteLine("Your two numbers add up to: " + adder.Add(firstNum, secondNum));

            Console.ReadLine();
        }
    }
}
