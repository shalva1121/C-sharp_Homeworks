namespace lesson1_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine()!);

            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine()!);

            Console.Write("Enter operation. ( +, -, *, / , % ): ");
            string action = Console.ReadLine()!;

            switch (action)
            {
                case "+":
                    Console.WriteLine($"Result: {x} + {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {x} - {y} = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {x} * {y} = {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"Result: {x} / {y} = {x / y}");
                    break;
                case "%":
                    Console.WriteLine($"Result: {x} % {y} = {y / 100 * x}");
                    break;
                default:
                    Console.WriteLine("ERROR: invalid operation");
                    break;
            }
        }

    }
}

