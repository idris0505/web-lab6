using System;

class Lab7
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter first number (or 'q' to quit):");
            string raw = Console.ReadLine();
            if (raw.Equals("q", StringComparison.OrdinalIgnoreCase)) break;

            try
            {
                if (!double.TryParse(raw, out double a))
                    throw new FormatException("Input is not a valid number.");

                Console.WriteLine("Enter operator (+ - * /):");
                string opRaw = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opRaw) || opRaw.Length != 1)
                    throw new InvalidOperationException("Operator must be single character.");
                char op = opRaw[0];
                if (!"+-*/".Contains(op))
                    throw new InvalidOperationException("Operator must be one of + - * /");

                Console.WriteLine("Enter second number:");
                if (!double.TryParse(Console.ReadLine(), out double b))
                    throw new FormatException("Second input is not a valid number.");

                double result = op switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => b == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : a / b,
                    _ => throw new InvalidOperationException("Unexpected operator.")
                };

                Console.WriteLine($"{a} {op} {b} = {Math.Round(result, 2)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Format error: {fe.Message}");
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine($"Math error: {dze.Message}");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine($"Operation error: {ioe.Message}");
            }
            catch (Exception ex)   
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("----------  round finished  ----------");
            }
        }
    }
}