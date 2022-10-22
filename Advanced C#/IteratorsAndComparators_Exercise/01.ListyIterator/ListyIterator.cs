using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> items = new List<T>();
        private int index = 0;

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }
        public bool Move()
        {
            if (index + 1 < items.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index < items.Count - 1;
        }
        public void Print()
        {
            if(items.Count==0)
            {
                throw new InvalidOperationException("Invalid operation!");
            }
            Console.WriteLine(items[index]);
        }
    }
}
