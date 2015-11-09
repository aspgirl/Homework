using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        public static void RunDelegate(Action<int> action, int count)
        {
            while (count > 0)
            {
                action(count);
                count--;
            }
        }

        public static void WriteToConsole (int count)
        {
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            RunDelegate(WriteToConsole, 2);
            Console.ReadLine();
        }
    }
}
