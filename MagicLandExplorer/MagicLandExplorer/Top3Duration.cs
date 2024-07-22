using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class Top3Duration
    {
        public static void ShowTop3Duration(List<Category> categories)
        {
            var top3Destinations = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 longest-duration destinations:");
            top3Destinations.ForEach(d => Console.WriteLine($"{d.Name}, Duration: {d.Duration} minutes"));
        }
    }
}
