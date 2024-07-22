using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class LongestDuration
    {
        public static void ShowLongestDuration(List<Category> categories)
        {
            var longestDurationDestination = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .FirstOrDefault();

            if (longestDurationDestination != null)
            {
                Console.WriteLine($"Destination with the longest duration: {longestDurationDestination.Name}, Duration: {longestDurationDestination.Duration} minutes");
            }
        }
    }
}
