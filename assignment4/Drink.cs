
using System.Threading.Channels;

namespace assignment4
{
    internal class Drink
    {
        public string Name;
        public double Price;
        public bool IsAlcoholic;

        public Drink(string name, double price, bool isAlcoholic)
        {
            Name = name;
            Price = price;
            IsAlcoholic = isAlcoholic;
        }

        public string GetDescription()
        {
            if (IsAlcoholic)
                return $"{Name} - {Price:.00} (Alcoholic)";
            return $"{Name} - {Price:.00} (Non-Alcoholic)";
        }
    }
}
