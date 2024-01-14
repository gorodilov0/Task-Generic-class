using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Generic_class
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Collection<T>
    {
        T[] data;

        public Collection() {
            data = new T[0];
        }

        public void AddItemArray(T item)
        {
            T[] newData = new T[data.Length + 1];

            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[0];
            }
            newData[data.Length] = item;
            data = newData;
        }

        public void DeleteItemArray(T item) {
            int index = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length; i++)
                {
                    if (i == index) continue;
                    newData[i] = data[i];
                    j++;
                }
                data = newData;
            }
            
        }

        public T GetItemArray(int index) { 
            if (index > -1 && index < data.Length)
            {
                return data[index];
            } 
            else throw new IndexOutOfRangeException();
        }

        public int GetLengthArray()
        {
            return data.Length;
        }
    }
}
