namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CalculateSquareDifference();

            CheckJackpot();
        }
        #region Task 1
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
        #endregion

        #region Task 2

        public static void CheckJackpot() {
            
                Console.WriteLine("Enter symbols: ");
                string[] symbols = Console.ReadLine().Split(' ');

                var isJackpot = true;
            
                for (int i = 1; i < symbols.Length; i++) {
                    if (symbols[i] != symbols[0]) {
                        isJackpot = false;
                        break;
                    } 
                }

                Console.WriteLine(isJackpot ? "Yes" : "No");               
        }
        
        #endregion


    }
}
