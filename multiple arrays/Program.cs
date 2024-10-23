using System.Threading.Channels;

namespace multiple_arrays
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
            Console.Write("Enter course name: ");
            Console.ReadLine();
            Console.Write("Enter number of students: ");
            int numberOfStudent = int.Parse(Console.ReadLine());
            string[] names = new string[numberOfStudent];
            int[] grades = new int[numberOfStudent];
            ReadNames(names);
            ReadGrades(grades, names);
            int highest = GetHighestGradeIndex(grades);
            Console.WriteLine();
            Console.WriteLine($"Student {names[highest]} has the highest grade: {grades[highest]}");
            
        }
        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name of student {i+1}: ");
                names[i] = Console.ReadLine();
            }
        }
        void ReadGrades(int[] grades, string[] names)
        {
            for(int i = 0;i < grades.Length; i++)
            {
                Console.Write($"Enter grade of {names[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());

            }
        }
        int GetHighestGradeIndex(int[] grades)
        {
            int higest = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > higest)
                    higest = i;
            }
            return higest;
            
        }
    }
}
