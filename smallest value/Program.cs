namespace smallest_value
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
            const int number = 20;
            int[] numbers = new int[number];

            FillArray(numbers);
            DisplayArray(numbers);
            Console.WriteLine($"Smallest number is: {GetSmallestNumber(numbers)}");
        }
        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(29, 101);
            }
        }
        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] +" ");
            }
            Console.WriteLine();
        }
        int GetSmallestNumber(int[] numbers)
        {
            int index = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < index)
                    index = numbers[i];

            }
            return index;
        }
    }
}
