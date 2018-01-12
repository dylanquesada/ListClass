using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList 
{
    public class CustomList<T> : IEnumerable
    {
       
        // IEnumerator
        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < capacity; index++)
            {
                yield return array[index];
            }
            //yield return throw IndexOutOfBoundsException;
        }
        // constructor
        public CustomList()
        {
            capacity = array.Length;

        }



        

        // member variables
        T[] array = new T[5];
        int count = 0;
        int capacity;
        // Accessors for member variables
        public int Count
        {
            get { return count; }
        }

        // Indexer
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        
        // member methods        
        public void Add(T input)
        {
            count++;
            if (count * 2 >= capacity)
            {
                capacity *=2;
            }            
            T[] result = new T[capacity];
            result[count - 1] = input;
            for (int i = 0; i < count - 1; i++)
            {
                result[i] = array[i];
            }
            array = result;            
        }



        public void Remove(T input)
        {

        }










        //Workspace for seeing what methods the List class has:
        List<string> list = new List<string>();
        public void Workspace()
        {
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            list.Remove("one");
        }





    }
}
