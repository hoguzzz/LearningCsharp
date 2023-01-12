using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<T>
    {
        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        }
        public void RemoveLastIndex()
        {
            T[] tempArray = items;
            items = new T[items.Length - 1];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
        public void Sort()
        {
            Array.Sort(items);
        }
        public void Cw()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public int Count
        {
            get { return items.Length; }    
        }


    }
}
