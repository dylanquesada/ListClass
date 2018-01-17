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
            get
            {
                if (i < count)
                {
                    return array[i];
                }
                else
                {
                    throw new Exception();
                }
            }
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
        //public bool Remove(T input)
        //{
        //    bool removed = false;
            

        //    return removed;
        //}        
        public bool Remove(T input)
        {            
            bool removed = false;
            T[] result = new T[capacity];
            
            for(int i = 0; i < count; i++)
            {
                if(array[i].Equals(input) && !removed)
                {
                    removed = true;
                    count--;
                    if (i < count) {
                        result[i] = array[i + 1];
                    }                    
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
        public CustomList<T> Zip(CustomList<T> list)
        {           
            CustomList<T> result = new CustomList<T>();
            
            int counter = 0;
            int counterTwo = 0;
            bool oneDone = false;
            bool twoDone = false;
            while(!oneDone || !twoDone)
            {                
                if (counterTwo < count)
                {
                    result.Add(array[counterTwo]);
                    counterTwo++;                    
                }
                else { twoDone = true; }
                if (counter < list.Count)
                {
                    result.Add(list[counter]);
                    counter++;
                }
                else { oneDone = true; }
            }
            return result;
        }
        public CustomList<int> Sort(CustomList<int> list)
        {
            CustomList<int> result = new CustomList<int>();
            result = list;
            int i, j;
            int N = count;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                       result = Swap(result, i, i + 1);
                    }
                }
            }
            return result;
        }

        public CustomList<int> Swap(CustomList<int> list, int left, int right)
        {
            int temporary;
            temporary = list[left];
            list[left] = list[right];
            list[right] = temporary;
            return list;
        }
        
    }
}
