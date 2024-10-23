using System.Diagnostics.CodeAnalysis;

namespace arraywithrandomintegers
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
        }
        void FillArray(int[] numbers)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }
        }
        void DisplayArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                sum += numbers[i];
                Console.WriteLine($"Element {i + 1} is: {sum}");
            }

        }
    }
} 
