using System;
using System.Collections.Generic;
using System.Linq;

class Partitioning
{
    public static void Run()
    {
        // Sample data
        List<int> numbers = Enumerable.Range(1, 10).ToList();

        // Take first 5 elements
        var firstFive = numbers.Take(5);

        // Skip the first 5 elements
        var remaining = numbers.Skip(5);

        Console.WriteLine("First 5 elements: " + string.Join(", ", firstFive));
        Console.WriteLine("Remaining elements: " + string.Join(", ", remaining));

    }
}
