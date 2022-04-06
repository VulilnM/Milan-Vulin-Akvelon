using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitalCities = new Dictionary<string, string>();
            
            //First, we add some values to our dictionary
            capitalCities.Add("Serbia", "Belgrade");
            capitalCities.Add("USA", "Washington,DC");
            capitalCities.Add("Japan", "Tokyo");
            capitalCities.Add("India", "New Delhi");
            capitalCities.Add("Ireland", "Dublin");
            capitalCities.Add("France", "Paris");

            //First lets see how many cities/states do we have in our dictionary
            Console.WriteLine("There are {0} states/cities in our dictionary, and they are:", capitalCities.Count);
            Console.WriteLine();

            //Now lets run through the dictionary and print out some values!
            foreach (KeyValuePair<string, string> keyValue in capitalCities) {
                Console.WriteLine("{0} with its capital city: {1}.", keyValue.Key, keyValue.Value);
            }
            Console.WriteLine();

            //Now, lets remove states/cities that are on the Asian continent
            Console.WriteLine("Deleting some state/city pairs on Asian continent...\n");
            foreach (KeyValuePair<string, string> keyValue in capitalCities)
            {
                if (keyValue.Key == "Japan" || keyValue.Key == "India")
                    capitalCities.Remove(keyValue.Key);
            }

            //Lets see if the deletion it worked
            Console.WriteLine("Now we are left with {0} state/city pairs", capitalCities.Count);
            Console.WriteLine("Remainng city/state pairs are: ");
            Console.WriteLine();
            foreach (KeyValuePair<string, string> keyValue in capitalCities)
            {
                Console.WriteLine("{0} with its capital city: {1}.", keyValue.Key, keyValue.Value);
            }

            //Now, we will let the user select a state, and we will print out the main city of the selected state to the user (if there is suc state in the dictionary)
            Console.WriteLine("Please, select a state that you want to know which capital belongs to it:");
            string userInput = Console.ReadLine();
            Console.WriteLine("User selected: {0}", userInput);

            if (capitalCities.ContainsKey(userInput))
                Console.WriteLine("The capital city of {0} is {1}", userInput, capitalCities[userInput]);
            else
                Console.WriteLine("There is no such state in the dictionary!");
        }
    }
}
