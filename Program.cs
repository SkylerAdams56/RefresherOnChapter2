using System.Security.Cryptography.X509Certificates;

namespace Student_Registration
{
    internal class Program
    {
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static string BirthYear { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            BirthYear = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + FirstName + " " + LastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + FirstName + "*" + BirthYear);
        }
    }
}