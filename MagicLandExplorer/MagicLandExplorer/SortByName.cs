using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class SortByName
    {
        public static void ShowSortedDestinations(List<Category> categories)
        {
            var sortedDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name)
                .ToList();

            Console.WriteLine("Destinations sorted alphabetically by name:");
            sortedDestinations.ForEach(d => Console.WriteLine(d.Name));
        }
    }
}
