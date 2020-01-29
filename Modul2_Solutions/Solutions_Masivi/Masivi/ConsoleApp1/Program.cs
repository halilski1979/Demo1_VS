using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // I   начин деклариране на масив:  int[] mas = new int[5]; 
            // II  начин деклариране на масив:  int arr = new int[] { 1, 2, 3, 4, 5, 6 };
            // III начин деклариране на масив:  int[] mas =  {1,2,3,4};
            


            //  Вход на елементи на масив
            // for (int i = 0; i < 5; i++)
            //{
            //   Console.Write($"A[{i}]=");
            // mas[i] = int.Parse(Console.ReadLine());
            // }
            //Console.WriteLine("********************");


            // Вход на елентите на масив
            int[] mas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            //Отпечатване1 на елементи на масив

          for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"A[{i}]={mas[i]}");
                Console.WriteLine();
            }
            Console.WriteLine("Печат с for  ********************");
            Console.WriteLine();

            //Отпечатване2 на елементи на масив
            int b = 0;
            foreach (var m in mas)
            {
                Console.WriteLine($"AA[{b}]={m}");
                b++;
            }
            Console.WriteLine("Печат с foreach  ********************");
            Console.WriteLine();

            //Отпечатване3 на елементи на масив
            Console.WriteLine(string.Join(" ",mas));
            Console.WriteLine("Печат с string.Join  ********************");
            Console.WriteLine();

            //Сума на елементите на масив
            int sum1 = 0;
            int sum = mas.Sum();
            for (int i = 0; i < mas.Length; i++)
            {
                sum1+= mas[i];
            }
            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"sum1={sum1}");
            Console.WriteLine("********************");


            // Максимален елемент  на масив
            int max = mas.Max();
            Console.WriteLine($"max={max}");
            Console.WriteLine("********************");


            // Минимален елемент  на масив
            int min = mas.Min();
            Console.WriteLine($"min={min}");
            Console.WriteLine("********************");

            //Средно аритметично на елементите на масив
            double av = mas.Average();
            Console.WriteLine($"Average={av}");
            Console.WriteLine("********************");

            //Обръщане на елементите на масив
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"A[{i}]={mas[i]}");
                Console.WriteLine();
            }
            



        }
    }
}
