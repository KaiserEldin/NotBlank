using System;
using System.Collections.Generic;

namespace Newclass
{
    class Newlist<T>
    {
        public T[] elements;
        public Newlist() {  }
        public Newlist(T[] elements) {  this.elements = elements; }

        public void addelement(T value) { elements.Append(value); }
        public T getElementByIndex(int index) {return elements[index];}
        public void delete(int index)
        {
            int i = 0;
            T[] newelements = Array.Empty<T>();
            foreach (T item in elements)
            {
                if (i != index) { newelements.Append(item);}
                i++;
            }
            elements = newelements;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}