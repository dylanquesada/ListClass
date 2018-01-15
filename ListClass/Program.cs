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
            CustomList<int> IntList = new CustomList<int>();
            IntList.Add(2);
            IntList.Remove(2);
            CustomList<int> list = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            //int expected = 7;
            // Act
            list.Remove(0);
            list.Remove(3);
            List<string> newList = new List<string>() {"One", "Two", "Three" };
            Console.WriteLine(newList.ToString());
            Console.Read();
        }
    }
}
