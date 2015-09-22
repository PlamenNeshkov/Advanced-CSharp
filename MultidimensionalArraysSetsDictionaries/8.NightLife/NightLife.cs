using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> venuesInCities = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, SortedSet<string>> performersInVenues = new Dictionary<string, SortedSet<string>>();


            bool validInput = true;
            while (validInput)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0] != "END")
                {
                    if (venuesInCities.ContainsKey(input[0]))
                    {
                        venuesInCities[input[0]].Add(input[1]);
                    }
                    else
                    {
                        venuesInCities[input[0]] = new SortedSet<string>();
                        venuesInCities[input[0]].Add(input[1]);
                    }
                    if (performersInVenues.ContainsKey(input[1]))
                    {
                        performersInVenues[input[1]].Add(input[2]);
                    }
                    else
                    {
                        performersInVenues[input[1]] = new SortedSet<string>();
                        performersInVenues[input[1]].Add(input[2]);
                    }
                }
                else
                {
                    validInput = false;
                }
            }

            foreach (var pair in venuesInCities)
            {
                Console.Write("{0}\n", pair.Key);
                foreach (var venue in pair.Value)
                {
                    Console.Write("->{0}: ", venue);
           
                    foreach (var perfomer in performersInVenues[venue])
                    {
                        Console.Write(perfomer + " ");
                    }                 
                    Console.WriteLine();
                }
            }
        }
    }
}
