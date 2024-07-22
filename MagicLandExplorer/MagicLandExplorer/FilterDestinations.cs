using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class FilterDestinations
    {
        public static void ShowFilteredDestinations(List<Category> categories)
        {
            var filteredDestinations = categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Duration < 100)
                .Select(d => d.Name)
                .ToList();

            Console.WriteLine("Destinations with duration less than 100 minutes:");
            filteredDestinations.ForEach(Console.WriteLine);
        }
    }
}
