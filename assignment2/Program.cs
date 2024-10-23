namespace assignment2
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
            int number = 1;
            while(number != 0 )
            {
                Console.WriteLine("Enter a positive integer: ");
                number = int.Parse(Console.ReadLine());

                if (CountPrimeFactors(number) == 1)
                {
                    Console.WriteLine($"The number {number} is a prime number");
                }
                else
                {
                    Console.WriteLine($"The number {number} has {CountPrimeFactors(number)} prime numbers");
                }

            }




        }
        int CountPrimeFactors(int number)
        {
            int count = 0;
            int divisor = 2;
            while (number > 1) {
                if (number % divisor == 0)
                {
                    number /= divisor;
                    count++;
                }
                divisor++;
            }
            return count;

        }
    }
}
