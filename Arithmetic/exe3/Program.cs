using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exee3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int sum = 0;
            int count = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i = a; i < b+1; i++)
            {
                sum = sum + i;
                count++;
            }
            Console.WriteLine(sum);

            Console.WriteLine(sum/count);
        }
    }
}
