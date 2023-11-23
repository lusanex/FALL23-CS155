// Define the delegate
delegate double MathOperation(double a, double b);


namespace Homework12_Lab1
{

    class Program
    {
        // Define methods
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : throw new InvalidOperationException("Division by zero is not allowed.");

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Signature: double MathOperation(double a, double b)");
            Console.WriteLine("Explanation: This delegate can reference any method that takes two double parameters and returns a double.");

            // Delegate usage
            MathOperation op;
            // Addition
            op = Add;
            Console.WriteLine($"Addition: 5 + 3 = {op(5, 3)}");

            // Subtraction
            op = Subtract;
            Console.WriteLine($"Subtraction: 5 - 3 = {op(5, 3)}");

            // Multiplication
            op = Multiply;
            Console.WriteLine($"Multiplication: 5 * 3 = {op(5, 3)}");

            // Division
            op = Divide;
            Console.WriteLine($"Division: 5 / 3 = {op(5, 3)}");

        }



    }
}