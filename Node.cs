using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T> where T : IComparable<T>
    {
        T value;

        Node<T>? left = null;
        Node<T>? right = null;
        public Node(T value)
        {
            this.value = value;
        }

        public void Print()
        {
            Console.Write(value + " "); // N
            left?.Print(); // L
            right?.Print(); // R
        }
        public void Add(T v)
        {
            if (v.CompareTo(value) < 0)
            {
                if (left == null) left = new(v);
                else
                    left.Add(v);
            }
            else
            {
                if (right == null) right = new(v);
                else
                    right.Add(v);
            }

        }
    }
}
