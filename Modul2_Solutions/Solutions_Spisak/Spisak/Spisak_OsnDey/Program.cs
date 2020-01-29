using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak_OsnDey
{
    class Program
    {
        static void Main(string[] args)
        {

            // Вход на елементи на списък на един ред
            var spisakInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var spisakDouble = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //var spisakString = Console.ReadLine().Split(' ').ToList();


            Console.WriteLine(string.Join(" ",spisakInt));




        }
    }
}
