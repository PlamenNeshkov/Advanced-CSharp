using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input = "";
            bool validInput = true;
            while (validInput)
            {
                input = Console.ReadLine();
                if (input != "search")
                {
                    string[] entry = input.Split('-');
                    phonebook.Add(entry[0], entry[1]);
                }
                else
                {
                    validInput = false;
                }
            }
            validInput = true;
            while (validInput)
            {
                input = Console.ReadLine();
                if (input != "exit")
                {
                    if (phonebook.ContainsKey(input))
                    {
                        Console.WriteLine("{0} -> {1}", input, phonebook[input]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input);
                    }
                }
                else
                {
                    validInput = false;
                }
            }
        }
    }
}
