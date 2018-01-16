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
            CustomList<int> list = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> otherList = new CustomList<int>() { 2, 4, 6 };
            Console.WriteLine(list.Zipper(otherList));
            //int expected = 7;
            //Act
            //list.Remove(0);
            //list.Remove(3);
            //List<string> newList = new List<string>() { "One", "Two", "Three" };
            //Console.WriteLine(newList.ToString());
            //CustomList<bool> list = new CustomList<bool>() { true, false, true };
            //Console.WriteLine(list.ToString());
            //Console.WriteLine(newList[1]);
            //Console.WriteLine(newList[5]);
            //List<string> newOne = new List<string>();
            //newOne = newList + newList;
            //Console.WriteLine(newOne);
            Console.Read();
        }
    }
}
