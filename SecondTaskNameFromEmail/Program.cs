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
            Console.WriteLine(NameFromEmail());
            Console.ReadLine();
        }

        public static string NameFromEmail()
        {
            Console.WriteLine("Type in your email email address in this format" +
                              "\nfirstName.lastName@exam.com");
            string email = Console.ReadLine();
            string name = email.Split('@')[0];
            string[] fullName = name.Split('.');
            char[] lastName = fullName[1].ToCharArray();
            lastName[0] = char.ToUpper(lastName[0]);

			char[] firstName = fullName[0].ToCharArray();
            firstName[0] = char.ToUpper(firstName[0]);

            return name = new string(lastName) + " " + new string(firstName); 
        }

    }
}