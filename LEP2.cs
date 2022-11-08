using System;
using System.Text.RegularExpressions;

namespace UC2
{
    public class LastName
    {
        //pattern needed for string
        public string reg = "^[A-Z][A-za-z]{2,}";
        //comparing both values using regex
        public bool FirstNameValidate(string lastname) => Regex.IsMatch(lastname, reg) ? true : false;
    }
    internal class LE1
    {
        static void Main(string[] args)
        {
            LastName ln = new LastName();
            //accepting user input
            Console.Write("Enter The Last Name:");
            string lname = Console.ReadLine();
            bool result = ln.FirstNameValidate(lname);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}
