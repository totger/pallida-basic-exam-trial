using System;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        public static string NameFromEmail(string email)
        {
            string[] fullName = email.Split('@')[0].Split('.');
            char[] lastName = fullName[1].ToCharArray();
            lastName[0] = char.ToUpper(lastName[0]);
			char[] firstName = fullName[0].ToCharArray();
            firstName[0] = char.ToUpper(firstName[0]);
            return new string(lastName) + " " + new string(firstName); 
        }
    }
}