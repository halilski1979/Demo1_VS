using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_03_MaxPoredica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            int start1 = 0;
            int start2 = 0;
            int lenght = 1;
            int bestLenght = 0;
            int bestStart = 0;
            int num = 0;
            for (int i = 1; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i-1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start1 = i;
                }

                if (lenght>bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = start1;
                    num = numbers[i];
                }
            }

            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(num +  " ");
            }




        }
    }
}
