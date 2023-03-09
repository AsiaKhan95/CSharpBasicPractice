using System.Security.Principal;

namespace CSharpBasicPractice
{
    public class Program
    {
        public enum Role
        {
            Admin,
            Editor,
            Author
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.Clear();
            if (name == "Asia")
            {
                Console.WriteLine($"Wellcom {name} ");
            }
            else {
                Console.WriteLine("Sorry Access Denied...");
            }
        }
    }
}