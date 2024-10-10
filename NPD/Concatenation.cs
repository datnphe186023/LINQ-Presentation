using System;
using System.Collections.Generic;
using System.Linq;

class Concatenation
{
    public static void Run()
    {
        List<int> firstList = new List<int> { 1, 2, 3 };
        List<int> secondList = new List<int> { 4, 5, 6 };

        // Concatenating two lists
        var combinedList = firstList.Concat(secondList);

        Console.WriteLine("Combined List: " + string.Join(", ", combinedList));

    }
}
