using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

namespace practice
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
            Console.WriteLine("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());
            GetGradeFeedback(score);
        }
        void GetGradeFeedback(int score)
        {
            if (score < 0 || score < 40)
            {
                Console.WriteLine("Your grade is: F");
                Console.WriteLine("Failed, please seek help");
            }
            else if (score > 39 && score < 60)
            {
                Console.WriteLine("Your grade is: D");
                Console.WriteLine("Barely passed, you should work harder");
            }
            else if (score > 59 && score < 70)
            {
                Console.WriteLine("Your grade is: C");
                Console.WriteLine("You passed, but consider reviewing the material");

            }
            else if (score > 59 && score < 80)
            {
                Console.WriteLine("Your grade is: B");
                Console.WriteLine("Good job, but there’s room for improvement.");
            }
            else
            {
                Console.WriteLine("A: Excellent work!");
            }
        }
    }
}

        
