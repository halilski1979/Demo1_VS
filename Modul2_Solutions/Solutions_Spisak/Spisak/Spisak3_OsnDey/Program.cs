using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak3_OsnDey
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int>() {1,2,3,4,5,6};
            List<string> name = new List<string>() {"Halil","Alish","Stefan","Maria","Petq" };

            
            // Добавя Аti  на последна позиция
            name.Add("Ati");
            Console.WriteLine(string.Join("; ",name));


            



        }
    }
}
