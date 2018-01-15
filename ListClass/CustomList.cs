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
            for(int index = 0; index < count; index++)
            {
                yield return array[index];
            }            
            //Exception IndexOutOfBoundsException = new Exception();
            throw new IndexOutOfRangeException();
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


        public bool Remove(T input)
        {
            bool removed = false;
            T[] result = new T[capacity];
            for(int i = 0; i < count; i++)
            {
                if(Equals(array[i], input) && !removed)
                {
                    removed = true;
                    result[i] = array[i + 1];
                    count--;
                }
                else if (removed)
                {
                    result[i] = array[i + 1];
                }
                else
                {
                    result[i] = array[i];
                }               
            }
            array = result;
            return removed;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += array[i];
            }
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++){
                result.Add(two[i]);
            }
            return result;
        }
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();
            for(int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                result.Remove(two[i]);
            }
            return result;
        }
        public CustomList<T> Zipper(CustomList<T> list)
        {
            CustomList<T> result = new CustomList<T>();
            return result;
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
