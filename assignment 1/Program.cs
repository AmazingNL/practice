namespace assignment_1
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
            Console.Write("Enter the running distance (in kilometer): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the time taken (in minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Do you want to calculate pace (min/km) or speed (km/hr)? ");
            string input = Console.ReadLine();
            if (input == "pace") Console.WriteLine($"Your pace is {GetPace(distance, time):.00} min/km");
            else if (input == "speed") Console.WriteLine($" Your speed is {GetSpeed(distance, time):.00} km/hr");
            else Console.WriteLine("Incorrect input");
        }
        double GetPace(double distance, int time)
        {
            return (double)time / distance;
           
        }
        double GetSpeed(double distance, int time)
        {
            return distance / ((double)time / 60);
        }

    }
}
