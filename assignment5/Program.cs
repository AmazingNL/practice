namespace assignment5
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
            Machine machine = ReadMachine();

            machine.DisplayInfo();
        }
        Machine ReadMachine()
        {
            Console.Write("Enter machine name: ");
            string name = Console.ReadLine();
            Console.Write("Enter number of working hours: ");
            int numOfWorkinghrs = int.Parse(Console.ReadLine());

            Machine mechaine = new(name, numOfWorkinghrs);
            return mechaine;
        }
    }
}
