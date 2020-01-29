using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10_03_IndexAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedete duma:");
            string word = Console.ReadLine().ToLower();


            char[] alphabet = new char[30];
            int j = 0;

            for (var i = 'a'; i <= 'z'; i++)
            {
                alphabet[j] = i;
                j++;
            }

            // Console.WriteLine(string.Join(" ",alphabet));

            for (int i = 0; i < word.Length; i++)
            {
                for (int j1 = 0; j1 < alphabet.Length; j1++)
                {
                    if (word[i] == alphabet[j1])
                        {
                        Console.WriteLine($"{word[i]} -> {j1}   ASCII code[{(int)word[i]}]");
                        }
                }
            }

        }
    }
}
