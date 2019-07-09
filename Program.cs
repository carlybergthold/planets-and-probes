using System;
using System.Collections.Generic;
using System.Linq;

namespace planets_and_probes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Pluto", "Jupiter", "Saturn", "Uranus", "Neptune"};

            // Create a list containing KeyValuePairs. Each KeyValuePair will hold the name of a spacecraft that we have launched, and the name of a planet that it has visited. The key of the KeyValuePair will be the probe name, and the value will be the planet it visited.

            var probeDestinations = new List<KeyValuePair<string, string>>();
            // Add some planet/probe combinations to the list

            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Endeavor 2", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Viking 2", "Saturn"));

            // Iterate over probeDestinations, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which probes have visited it.

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                var matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach(KeyValuePair<string, string> dest in probeDestinations)
                {
                    string probe = dest.Key;
                    string destination = dest.Value;

                    if (destination == planet) {
                        matchingProbes.Add(probe);
                    }
                }
                bool isEmpty = !matchingProbes.Any();
                if (isEmpty) {
                    Console.WriteLine($"{planet}: No probes; innocence remains");
                } else {
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                }
            }
            // Example Output in the Terminal
            // Mars: Viking, Opportunity, Curiosity
            // Venus: Mariner, Venera
        }
    }
}
