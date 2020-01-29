using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Обръща масива
            Array.Reverse(nums);
            Console.WriteLine(string.Join(" ",nums));

            //Сортира масива 
            Array.Sort(nums);
            Console.WriteLine(string.Join(" ",nums));

            // Метода Clear
            Array.Clear(nums,1,2);
            Console.WriteLine(string.Join(" ",nums));
            // Дава стойност 0 на 2 елемента от индекс [1] на масива nums


            //Метода CopyTo
            int[] source = new int[] {7,8,9};
            source.CopyTo(nums,1);
            Console.WriteLine(string.Join(" ", nums));
            // Копира масива source  в масива nums от индекс[1], като замества сойностите на индексите [1] [2] [3] с числата от
        }
    }
}
