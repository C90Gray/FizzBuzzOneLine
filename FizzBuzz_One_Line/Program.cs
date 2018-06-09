using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_One_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a whole number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine((x % 15==0) ? "FizzBuzz" : ((x % 3==0) ? "Fizz" : ((x % 5==0) ? "Buzz": x.ToString())));
        }
    }
}
