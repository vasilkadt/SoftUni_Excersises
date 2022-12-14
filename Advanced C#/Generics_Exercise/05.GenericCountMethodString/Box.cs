using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T: IComparable<T>
    {
        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().Trim();
        }

        public void Swap(ref int index1, ref int index2)
        {
            T temp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
        }

        public int Count(T itemToCompare)
        {
            int count = 0;
            foreach (var item in Items)
            {
                if(item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
