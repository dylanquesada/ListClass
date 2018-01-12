using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        // member variables
        T[] array = new T[100];
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        // constructor
        public CustomList()
        {

        }
        //list.Add(1);
        //list.Remove(1);
        //list.Zip();
        //List<int> list = new List<int>();

        // member methods
        public int Count()
        {
            return 0; //return counter of length.
        }
        public void Add(T input)
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
