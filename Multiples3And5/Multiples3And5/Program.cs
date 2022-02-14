using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0);
            
            var sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
