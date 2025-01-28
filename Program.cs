using System;

namespace lab6_del
{
    delegate int calculatedDelegate(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operation;

            Console.WriteLine("enter num1:");
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("enter num2:");
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("enter 1 for Addition");
            Console.WriteLine("enter 2 for Subtraction");
            Console.WriteLine("enter 3 for Multiplication");
            Console.WriteLine("enter 4 for Division");
            int.TryParse(Console.ReadLine(), out operation);
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
