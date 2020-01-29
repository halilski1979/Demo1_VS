using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10_02_SreshtanoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[i+1] && i<nums[nums.Length])
                {
                    br++;
                }
            }
            Console.WriteLine(br);

            int[] br1 = new int[nums.Length];
        }
    }
}
