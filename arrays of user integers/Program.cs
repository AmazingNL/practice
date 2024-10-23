namespace arrays_of_user_integers
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
            int[] numbers = new int[3];
            FillArray(numbers);
            Console.WriteLine($"Sum: {CalculateSum(numbers)}");
            Console.WriteLine($"Average: {CalculateAverage(numbers):.00}");
        }
        void FillArray(int[] numbers)
        {
            Console.WriteLine($"Enter 3 integers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;

            }
        }

        int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        double CalculateAverage(int[] numbers)
        {
            int average = CalculateSum(numbers) / numbers.Length;
            return average;
        }

    }
}

