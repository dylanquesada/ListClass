using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace ListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>() {"A", "B", "D", "C", "A" };
            list.Sort();
            Console.WriteLine(list);
            Console.Read();
        }
    }
}
