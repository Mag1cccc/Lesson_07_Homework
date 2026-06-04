namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSquareDifference();
        }

        public static void CalculateSquareDifference()
        {
            Console.WriteLine("Enter radius of the circle: ");

            if (int.TryParse(Console.ReadLine(), out var radius))
            {
                var largeSquareArea = 4 * (radius * radius);
                var smallSquareArea = 2 * (radius * radius);
                var difference = largeSquareArea - smallSquareArea;
                Console.WriteLine($"The difference is: {difference}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
