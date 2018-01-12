using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList 
{
    public class CustomList<T>
    {
        //Workspace for seeing what methods the List class has:
        List<string> list = new List<string>();
        public void Workspace()
        {
            list.Remove("one");
        }
        //
        // member variables
        T[] array = new T[0];
        int count = 0;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
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
        
        public void Add(T input)
        {            
            T[] product = new T[array.Length + 1];
            product[array.Length + 1] = input;
            for (int i = 0; i < array.Length; i++)
            {
                product[i] = array[i];
            }
            array = product;
            Count = array.Length;    
        }
        public void Remove(T input)
        {

        }
    }
}
