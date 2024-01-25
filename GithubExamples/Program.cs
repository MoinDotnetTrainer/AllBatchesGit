using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add();
        }

        public static void add()
        {
            int x = 45, y = 56, z;
            z = x + y;
            Console.WriteLine("add is :" + z);
        }
    }
}
