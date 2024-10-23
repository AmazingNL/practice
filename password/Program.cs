using System.ComponentModel.Design;

namespace password
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
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            IsValidPassword(password);
        }
        bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                Console.WriteLine("Not up to 8");
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsUpper(password[i]))
                    Console.WriteLine("no uppercase");
                if (!char.IsDigit(password[i]))
                    Console.WriteLine("no digit");

            }
            return true;
        }
    }
}
