using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7  ;
            Console.WriteLine(SearchInsert(nums, target));

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

        public static int SearchInsert(int[] nums, int target)
        {
            int index = Search(nums, target);
            if (index < 0)
            {
                foreach (int item in nums)
                {
                    if (item > target)
                    {
                        index = Array.IndexOf(nums, item);
                        break;
                    }
                }

                if (index < 0)
                {
                    index = nums.Length;
                }

            }
            return index;


        }
    }
}
