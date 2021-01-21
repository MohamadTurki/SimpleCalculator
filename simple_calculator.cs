using System;

namespace App
{
  class Program
  {

    static void calc() {
        int num1, num2;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Select an operation: -, +, /, *");
        Console.Write("> ");
        
        switch (Console.ReadLine())
        {
            case "+":
                Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
            case "-":
                Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
            case "*":
                Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
            case "/":
                Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                    break;
        }
    }

    static void Main(string[] args)
    {
        calc();
    }
 }
}