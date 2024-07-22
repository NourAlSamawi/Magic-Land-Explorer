using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("data.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Show filtered destinations (duration < 100 minutes)");
                Console.WriteLine("2. Show destination with the longest duration");
                Console.WriteLine("3. Sort destinations alphabetically by name");
                Console.WriteLine("4. Show top 3 longest-duration destinations");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FilterDestinations.ShowFilteredDestinations(categories);
                        break;
                    case "2":
                        LongestDuration.ShowLongestDuration(categories);
                        break;
                    case "3":
                        SortByName.ShowSortedDestinations(categories);
                        break;
                    case "4":
                        Top3Duration.ShowTop3Duration(categories);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
