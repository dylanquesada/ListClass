using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    class ListClass<T>
    {
        // member variables
        T[] array;
        // constructor
        public ListClass()
        {

        }
        //list.Add(1);
        //list.Remove(1);
        //list.Zip();
        //List<int> list = new List<int>();

        // member methods
        public void Add(ref T input)
        {            
            T[] product = new T[array.Length + 1];
            product[array.Length + 1] = input;
            for (int i = 0; i < array.Length; i++)
            {
                product[i] = array[i];
            }       
        }
    }
}
