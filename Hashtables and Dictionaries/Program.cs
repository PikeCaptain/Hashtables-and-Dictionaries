using System;
using System.Collections;
using System.Collections.Generic;

namespace Hashtables_and_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a dicitonary to store the top games with an integer key and a string value
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            // Adds top games to the dicitionary with their corresponding ranking
            topGames.Add(1, "Star Wars: Battlefront");
            topGames.Add(2, "DCS");
            topGames.Add(3, "Super Smash Bros");
            topGames.Add(4, "No Man's Sky");
            topGames.Add(5, "Street Fighter 6");
            topGames.Add(6, "Decenders");
            topGames.Add(7, "Minecraft");
            topGames.Add(8, "Legend of Zelda: Tears of the kingdom");
            topGames.Add(9, "Fortnite");
            topGames.Add(10,"Forza Horizon 5");

            // Iterate through each key-value pair in the topGames dictionary
            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                // Print the key through each key-value in the topGames dictionary
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Checks if the dictionary contains a key for the fourth game
            if (topGames.ContainsKey(4)) 
            {
                // Prints the name of the favorite game (No Man's Sky)
                Console.WriteLine($"My favorite game is: {topGames[4]}");
            }

            // Declares a string variable to hold the result
            string result = "";


            //Attempts to get the value associated with key 11 (which does not exist)
            topGames.TryGetValue(11, out result);

            // Checks if a game was found for the eleventh position
            if(result != "")
            {
                // Prints the found game
                Console.WriteLine(result);
            }
            else
            {
                // Informs the user that there is no game in that position
                Console.WriteLine("There is no game in the eleventh grade");
            }

            // Checks if the dictionary contains a key for the fifth game
            if (topGames.ContainsKey(5))
            {
                // Updates the name of the fifth game
                topGames[5] = "Street Fighter 6";
            }

            // Prints the name of the fifth game
            Console.WriteLine(topGames[5]);

            // Creates a Hashtable from the topGames dictionary
            Hashtable hashtable = new Hashtable(topGames);

            // Retrieves the favorite game using the key 4 from the Hashtable
            string favGame = (string)hashtable[4];

            // Prints the favorite game
            Console.WriteLine($"Favorite game: {favGame}");

            // Creates a Hashtable to store state capitals
            Hashtable capitals = new Hashtable()
            {
                {"Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"Texas", "Austin" },
                {"Ohio", "Columbus" }
            };

            // Iterates through each key-value pair in the capital Hashtable
            foreach (DictionaryEntry kvp in capitals)
            {
                // Prints the state and its capital
                Console.WriteLine($"key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
