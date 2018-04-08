using System;
using System.Linq;
using System.Collections.Generic;

/* 
 * Write a function that, given a list and a target sum, returns zero-based indices of any two distinct elements 
 * whose sum is equal to the target sum. If there are no such elements, the function should return null.
    
   For example, 
   FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return a Tuple<int, int> containing any of the following pairs of indices:
        1 and 4 (3 + 9 = 12)
        2 and 3 (5 + 7 = 12)
        3 and 2 (7 + 5 = 12)
        4 and 1 (9 + 3 = 12)
*/
class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var hash = new HashSet<int>();
        list.ToList().ForEach(x => hash.Add(x));
        /* hashset from list */
        for (int i = 0; i < hash.Count; i++)
        {
            /* finding sum from list[i] + list[j] */
            var diff = sum - list[i];
            if (hash.Contains(diff) && i != list.IndexOf(diff))
            /* if list[j] in hashset */
            {
                var index = list.IndexOf(diff);
                return new Tuple<int, int>(i, index);
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}