namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[] numbers = new int[20];
            FillNumbers(numbers);
            GetAverage(numbers);
            DisplayNumbers(numbers, GetAverage(numbers));
        }
        void FillNumbers(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
        }
        int GetAverage(int[] numbers)
        {
            int average = 0;
            for (int i = 0; i < numbers.Length; i++) {
                average += numbers[i];
            }
            return average / numbers.Length;
        }
        void DisplayNumbers(int[] numbers, int average)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < average)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (numbers[i] > average)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
