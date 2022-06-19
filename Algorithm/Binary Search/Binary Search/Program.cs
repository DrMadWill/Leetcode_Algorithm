using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {

        //https://leetcode.com/problems/binary-search/
        static void Main(string[] args)
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 9;
            Console.WriteLine(Search(nums,target));
        }

        public static int Search(int[] nums, int target)
        {
            foreach (int item in nums)
            {
                if (item == target)
                {
                    return Array.IndexOf(nums, item);
                }
            }
            return -1;
        }
    }
}
