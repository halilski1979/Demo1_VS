using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_02_SpisakKraynosti
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers = new List<int>() { 2,3,4,9,4,2,9,4,6,8,2,9,3};

            int max = numbers.Max();
            int min = numbers.Min();
           
            // I начин
            //Console.WriteLine(string.Join("|",numbers.Where( x=>x==max )));
            //Console.WriteLine(string.Join("|", numbers.Where(x => x == min)));

            // II начин
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i]==max || numbers[i]==min)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Sort();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
