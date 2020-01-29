using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak1_OsnDey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy na elementite na spisak: ");
            int brSp = int.Parse(Console.ReadLine());

            List<int> spisak = new List<int>();
            for (int i = 0; i < brSp; i++)
            {
                Console.Write($"A[{i}]=");
                spisak.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine("********************");

            // Отпечатване1
            foreach (var item in spisak)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*******foreach*************");
            Console.WriteLine();

            // Отпечатване2
            Console.WriteLine(string.Join(" ",spisak));
            Console.WriteLine("*********string.Join***********");
            Console.WriteLine();

            // Отпечатване3
            for (int i = 0; i < spisak.Count; i++)
            {
                Console.Write(spisak[i]);
            }
            Console.WriteLine();
            Console.WriteLine("*********for***********");
            Console.WriteLine();

            Console.WriteLine(spisak[2]);
        }
    }
}
