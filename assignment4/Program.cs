using System.Diagnostics.CodeAnalysis;

namespace assignment4
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
            Drink[] drinks = new Drink[4];

            drinks[0] = new Drink("Coca cola", 3.00, false);
            drinks[1] = new Drink("Orange juice", 3.00, false);
            drinks[2] = new Drink("Beer", 3.50, true);
            drinks[3] = new Drink("Wine", 4.50, true);

            DisplayDrinks(drinks);

            double sum = 0;
            for (int i = 1; i < drinks.Length; i++) {
                Console.Write("Select a drink to order: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0) break;

                Drink selectedDrink = drinks[input - 1]; 
                Console.Write($"How many {selectedDrink.Name} do you want to order? ");
                int input1 = int.Parse(Console.ReadLine());
                sum = sum + selectedDrink.Price * input1;

            }
            Console.WriteLine($"Total price to pay: {sum:.00}");
        }
        void DisplayDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
                Console.WriteLine($"{i+1}. {drinks[i].GetDescription()}");
        }


    }
}
