namespace vowel
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
            Console.WriteLine("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            if (IsLetterVowel(letter) == true)
            {
                Console.WriteLine($"{letter} is a vowel");
            }
            else {
                Console.WriteLine($"{letter} is a consonant");
            }
        }
        bool IsLetterVowel(char letter)
        {
            switch (letter) { 
                case 'a': return true; break;
                case 'e': return true; break;
                case 'i': return true; break;
                case 'o': return true; break;
                case 'u': return true; break;
                default: return false;
            }
        }
    }
}
