using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var runAgain = true;
            while (runAgain)
            {
                Console.Write("Enter an integer: ");
                var answerInt = int.Parse(Console.ReadLine());
                if (answerInt % 2 == 0)
                {
                    Console.WriteLine($"The number {answerInt} is even");
                }
                else
                {
                    Console.WriteLine($"the number {answerInt} is odd");
                }
                Console.WriteLine("Want to run again? Y or N: ");
                if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}
