using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeSquareCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            do
            {
                Console.Clear();
                var valid = true;
                Console.Write("a = ");
                valid = int.TryParse(Console.ReadLine(), out int a);
                if (!valid) return;
                Console.Write("b = ");
                valid = int.TryParse(Console.ReadLine(), out int b);
                if (!valid) return;
                var result = solution.WholeSquareCount(a, b);
                Console.WriteLine(string.Join(", ", Array.ConvertAll(result, x => x.ToString())));
                Console.Write("Again? (y/n)");

            } while (Console.ReadKey(false).Key == ConsoleKey.Y);

        }
    }
}
