using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Danh sách số nguyên
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };

        //Join hai danh sách dựa trên giá trị chung
       var joinedList = from num1 in list1
                        join num2 in list2 on num1 equals num2
                        select new { num1, num2 };

        Console.WriteLine("Join result:");
        foreach (var item in joinedList)
        {
            Console.WriteLine($"Num1: {item.num1}, Num2: {item.num2}");
        }

        //List<(int, int)> joinedList = new List<(int, int)>();
        //foreach (int num1 in list1)
        //{
        //    foreach (int num2 in list2)
        //    {
        //        if (num1 == num2)
        //        {
        //            joinedList.Add((num1, num2));
        //        }
        //    }
        //}

        //Console.WriteLine("Join result:");
        //foreach (var item in joinedList)
        //{
        //    Console.WriteLine($"Num1: {item.Item1}, Num2: {item.Item2}");
        //}


        //Projection: Chỉ lấy các số chẵn từ danh sách đầu tiên và nhân đôi giá trị
        var projectedList = from num in list1
                       where num % 2 == 0
                       select num * 2;

        Console.WriteLine("\nProjection result (even numbers doubled):");
        foreach (var item in projectedList)
        {
            Console.WriteLine(item);
        }

        //List<int> projectedList = new List<int>();
        //foreach (int num in list1)
        //{
        //    if (num % 2 == 0)
        //    {
        //        projectedList.Add(num * 2);
        //    }
        //}

        //Console.WriteLine("\nProjection result (even numbers doubled):");
        //foreach (var item in projectedList)
        //{
        //    Console.WriteLine(item);
        //}


        // Aggregation: Tính tổng của các phần tử trong danh sách đầu tiên
        int sum = list1.Sum();
        Console.WriteLine($"\nAggregation result (sum of list1): {sum}");

        //int sum = 0;
        //foreach (int num in list1)
        //{
        //    sum += num;
        //}

        //Console.WriteLine($"\nAggregation result (sum of list1): {sum}");
    }
}
