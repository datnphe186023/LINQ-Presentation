using System;
using System.Collections.Generic;
using System.Linq;

class Generation
{
    public static void Run()
    {
        // Generate a sequence of numbers from 1 to 5
        var numberSequence = Enumerable.Range(1, 5);

        // Generate a sequence of the same value repeated 5 times
        var repeatedValues = Enumerable.Repeat("Test", 5);

        Console.WriteLine("Number Sequence: " + string.Join(", ", numberSequence));
        Console.WriteLine("Repeated Values: " + string.Join(", ", repeatedValues));

    }
}
