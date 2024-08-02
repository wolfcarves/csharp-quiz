using System;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
        string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

        double result = PerformOperation(num1, num2, operation);
        Console.WriteLine($"The result is: {result}");

        Console.WriteLine("Calculation attempt finished.");
    }

    static double PerformOperation(double num1, double num2, string operation)
    {
        // Perform the operation based on the num1 and num2 values and return the result
        return 0;
    }
}