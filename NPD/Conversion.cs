using System;
using System.Collections.Generic;
using System.Linq;

class Conversion
{
    public static void Run()
    {
        // Sample data
        List<string> numbersAsString = new List<string> { "1", "2", "3" };

        // Convert strings to integers
        var numbers = numbersAsString.Select(int.Parse);

        Console.WriteLine("Converted Numbers: " + string.Join(", ", numbers));

    }
}
