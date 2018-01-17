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
            CustomList<int> Nlist = new CustomList<int>() { 1, 999, 3000 };
            // Act
            List<int> list = new List<int>() { 1, 2, 3 };
            Console.WriteLine(list[4]);
            Console.Read();
        }
    }
}
