//Author: Jean Bryant Figueroa
//Course: COMP-003A
//Facualty: Johnathan Cruz
//Purpose: Demonstrate selection statements in C#.

namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterative Statements Demo\n");
            //prompt for a postive interget
            int num; 
            Console.Write("Enter a postive interger to generate its multiplaction table: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplaction Table for {num}");
            //
            for (int i = 0; i <= 10; i++)
            {
                //
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
            //
            Console.WriteLine("\nReversed Multiplacation Table:");
            int reverse = 10; //start at 10
            //loop and generate multiplacation in reverse
            while (reverse > 0)
            {
                Console.WriteLine($"{reverse} x {num} = {reverse * num}");
                // decrement the reverse
                reverse--;
            }
            //Fibonacci sequence with a do while loop
            /*
            Console.WriteLine("\nFibonacci Series:");
            int firstNumber = 0, secondNumber = 1, nextNumber;
            Console.Write($"{firstNumber} {secondNumber} ");
            int count = 2;

            do
            {
            }
            */
        }
    }
}
