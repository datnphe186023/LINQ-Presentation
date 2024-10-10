using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Data Source
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //Deferred Execution (Lazy Execution)
        var query = numbers.Where(n => n > 3);

        numbers.Add(6);

        foreach (var number in query)
        {
            Console.WriteLine(number);
        }

        //Extension Method
        var result = numbers.SkipLast(2);
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
}