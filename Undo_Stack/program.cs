using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackArray
{

    public class stack<T> : IEnumerable<T>
    {
        //creating array
        T[] items = new T[0];

        //no. of items
        int size;

        public void push(T item)
        {
            //if size==length grow boundary
            if (size == items.Length)
            {
                int newlength = size == 0 ? 4 : size * 2;

                T[] newArray = new T[newlength];
                items.CopyTo(newArray,0);
                items = newArray;
            }
            items[size] = item;
            size++;
        }

        public T pop()
        {
            if (size == 0)
            {
                Console.WriteLine("Stack Empty");
            }
            size--;
            return items[size];
        }

        public void clear()
        {
            size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return items[i];
                Console.WriteLine(items[i]);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void display()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
    public class program
    {

        static void Main(string[] args)
        {
            stack<int> s = new stack<int>();
           // s.push(10);
           // s.push(11);
           // s.pop();
           //// s.GetEnumerator();
           // s.display();

        }
    }
}
