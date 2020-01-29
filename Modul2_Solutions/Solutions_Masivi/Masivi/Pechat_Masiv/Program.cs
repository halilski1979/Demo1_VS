using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pechat_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            // => foreach comment from GiyHub
            foreach (var a in nums)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Печат foreach");
            Console.WriteLine();

            // => string.Join
            Console.WriteLine(string.Join(" ",nums));
            Console.WriteLine("Печат string.Join");
            Console.WriteLine();

            // => for
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"A[{i}]={nums[i]}");
            }
            Console.WriteLine("Печат for ");
        }
    }
}
