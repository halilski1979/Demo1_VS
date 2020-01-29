using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10_01_Zakraglqne
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundNums[i] =(int) Math.Round(nums[i],MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundNums.Length; i++)
            {
                Console.WriteLine(roundNums[i]);
            }
        }
    }
}
