

using System.Threading.Channels;

namespace assignment5
{
    internal class Machine
    {
        public string Name;
        public int NumberOfWorkingHours;

        public Machine(string name, int numberOfWorkingHours)
        {
            Name = name;
            NumberOfWorkingHours = numberOfWorkingHours;
        }

        public int numberOfWorkingHours {
            get { return NumberOfWorkingHours; }
            set
            {
                if (value >= 0)
                    NumberOfWorkingHours = value;
            }
        }
        bool NeedsMaintenance
        {
            get
            {
                if (NumberOfWorkingHours >= 10000) return true;
                return false;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Machine name: {Name}");
            Console.WriteLine($"Number of working hours: {NumberOfWorkingHours}");
            if (NeedsMaintenance == true)
                Console.WriteLine($"Needs maintenance: yes");
            else Console.WriteLine($"Needs maintenance: no");
        }
    }
}
