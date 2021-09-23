using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueSums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<List<int>>
            {
                new() {1, 2, 3},    // unique (6)
                new() {1, 2, 3},    // not unique
                new() {4, 3, 2},    // unique (9)
                new() {4, 3, 2},    // not unique
                new() {4, 3, 2},    // not unique
                new() {1, 1, 1},    // unique (3)
                new() {4, 3, 2},    // not unique
                new() {1, 2, 3},    // not unique
                new() {1, 1, 1},    // not unique
                new() {1, 1, 1, 2}, // unique (4)
                new() {1, 1, 1}     // not unique

                // should equal 23
            };

            var uniqueSum = GetUniqueSubListSum(list);
            Console.WriteLine($"Unique sum is: {uniqueSum}");
            Console.ReadLine();
        }

        public static int GetUniqueSubListSum(IList<List<int>> list)
        {
            var sum = 0;
            var duplicateItems = new List<List<int>>();

            foreach (var item in list)
            {
                // if item has already been determined to be a duplicate, continues to next to limit redundant iterations
                if (duplicateItems.Contains(item)) continue;

                // iterates through list excluding current item
                foreach (var checkItem in list.Where(x => x != item))
                {
                    // checks if the found item has the same values as the current item
                    // and if it comes after the the current item
                    // if it is the same, it will flag it as a duplicate
                    if (item.SequenceEqual(checkItem) && list.IndexOf(checkItem) > list.IndexOf(item))
                    {
                        duplicateItems.Add(checkItem);
                    }
                }

                sum += item.Sum(x => x);
            }

            return sum;
        }
    }
}
