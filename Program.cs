using System;

namespace lab6_del
{
    delegate int calculatedDelegate(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, operation = 0;

            try
            {
                Console.WriteLine(" enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" enter num2 :");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter 1 for Addition");
                Console.WriteLine(" Enter 2 for Subtraction");
                Console.WriteLine(" Enter 3 for Multiplication");
                Console.WriteLine(" Enter 4 for Division");
                operation = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid number try again");
            }
            if (operation == 1)
            {
                calculatedDelegate(num1, num2, (a, b) => a + b);
            }
            else if (operation == 2)
            {
                calculatedDelegate(num1, num2, (a, b) => a - b);


            }
            else if (operation == 3)
            {
                calculatedDelegate(num1, num2, (a, b) => a * b);
            }
            else if (operation == 4)
            {

                try
                {
                    calculatedDelegate(num1, num2, (a, b) => a / b);
                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else Console.WriteLine("not found");



        }
        static void calculatedDelegate(int num1, int num2, calculatedDelegate delg)
        {
            var result = delg(num1, num2);
            Console.WriteLine($"result={result}");
        }
    }
}
