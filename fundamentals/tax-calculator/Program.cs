using System;

    // Billing.cs
    namespace Billing
        {
            public class Calculator
            {
                public static double CalculateTax(double subtotal, double taxRate = 0.08)
                {
                    return subtotal * taxRate;
                }
                public static double CalculateTotal(double subtotal, double tax)
                {
                    return subtotal + tax;
                }
            }
        
    // Program.cs
    class Program
    {
            static void Main()
            {
                double subtotal = 49.99;
                
                double tax = Calculator.CalculateTax(subtotal);
                double total = Calculator.CalculateTotal(subtotal, tax);
                
                Console.WriteLine($"Subtotal: {subtotal:C}");
                Console.WriteLine($"Tax: {tax:C}");
                Console.WriteLine($"Total: {total:C}"); 
            }
}
        }
