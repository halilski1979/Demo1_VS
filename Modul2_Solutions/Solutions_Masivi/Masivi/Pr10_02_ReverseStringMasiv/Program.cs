﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10_02_ReverseStringMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i]+" ");
            }
        }
    }
}
