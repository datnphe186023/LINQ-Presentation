using System;
using System.Collections.Generic;
using System.Linq;

class EqualityProgram
{
    public static void Run()
    {
        List<int> list1 = new List<int> { 1, 2, 3 };
        List<int> list2 = new List<int> { 1, 2, 3 };

        // Check if the two lists are equal
        bool areEqual = list1.SequenceEqual(list2);

        Console.WriteLine("Are the two lists equal? " + areEqual);

    }
}
