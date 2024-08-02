# Coding Activity: Basics of Exception Handling in C#

## Objective

To practice implementing exception handling using `try`, `catch`, `finally` blocks, and the `throw` keyword in C#.

## Activity Description

You will create a simple console application that simulates a basic calculator. This calculator should handle exceptions that might occur during user input and calculation. 

The following operations should be supported: 
- addition
- subtraction
- multiplication
- division

**Sample Code**

```csharp
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
        string operation = Console.ReadLine().ToLower();

        double result = PerformOperation(num1, num2, operation);
        Console.WriteLine($"The result is: {result}");

        Console.WriteLine("Calculation attempt finished.");
    }

    static double PerformOperation(double num1, double num2, string operation)
    {
        // Perform the operation based on the num1 and num2 values and return the result
    }
}
```

Update the sample code to handle the following scenarios using exception handling:

**Successful Calculation (any operation)**

```
Enter the first number:
10
Enter the second number:
5
Enter the operation (add, subtract, multiply, divide):
add
The result is: 15
Calculation attempt finished.
```

**Invalid Input (non-numeric value in any number)**

```
Enter the first number:
abc
Invalid input. Please enter numeric values.
Calculation attempt finished.
```

**Division by Zero**

```
Enter the first number:
10
Enter the second number:
0
Enter the operation (add, subtract, multiply, divide):
divide
Cannot divide by zero.
Calculation attempt finished.
```

**Unsupported Operation**

```
Enter the first number:
10
Enter the second number:
5
Enter the operation (add, subtract, multiply, divide):
modulo
An error occurred: The specified operation is not supported.
Calculation attempt finished.
```
