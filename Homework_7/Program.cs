namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CalculateSquareDifference();

            // CheckJackpot();

            // CalculateTotalPoints();

            // CalculateWeeklySalary();

            CountProgressDays();
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
                var symbols = Console.ReadLine().Split(' ');

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

        #region Task 3

        public static void CalculateTotalPoints() {
            var win = 3;
            var draw = 1;
            var lose = 0;

            Console.WriteLine("Enter number of wins: ");
            int.TryParse(Console.ReadLine(), out var winCount);

            Console.WriteLine("Enter number of draws: ");
            int.TryParse(Console.ReadLine(), out var drawCount);

            Console.WriteLine("Enter number of losses: ");
            int.TryParse(Console.ReadLine(), out var lostCount);

            var totalPoints = (winCount * win) + (drawCount * draw) + (lostCount * lose);
            Console.WriteLine(totalPoints);

        }

        #endregion

        #region Task 4

        public static void CalculateWeeklySalary() {
            Console.WriteLine("Enter hours for 7 days (separated by space): ");
            string input = Console.ReadLine();

            var hoursStrings = input.Split(' ');
            var hours = new int[7];
            var totalSalary = 0;

            for (var i = 0; i < hoursStrings.Length; i++)
            {
                int.TryParse(hoursStrings[i], out hours[i]);
            }

            for (var i = 0; i < hours.Length; i++) {
                if (i < 5)
                {
                    if (hours[i] <= 8)
                    {
                        totalSalary += hours[i] * 10;
                    }
                    else
                    {
                        totalSalary += (8 * 10) + (hours[i] - 8) * 15;
                    }

                }
                else 
                {
                    totalSalary += hours[i] * 20;
                }
            }

            Console.WriteLine(totalSalary);

        }

        #endregion

        #region Task 5

        public static void CountProgressDays()
        {
            Console.WriteLine("Enter daily training results separated by space: ");
            var input = Console.ReadLine();
            var parts = input.Split(' ');
            var days = new int[parts.Length];

            for (var i = 0; i < parts.Length; i++) {
                int.TryParse(parts[i], out days[i]);
            }

            int progressCount = 0;

            for (var i = 1; i < days.Length; i++) {
                if (days[i] > days[i - 1])
                {
                    progressCount++;    
                }
            }
            Console.WriteLine(progressCount);
        }

        #endregion


    }
}
