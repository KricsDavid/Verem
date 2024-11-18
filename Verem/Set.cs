using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    public class Set
    {
        private double[] elements;
        private int count; 
        private int capacity;

        public Set()
        {
            this.capacity = 50;
            this.elements = new double[capacity];
            this.count = 0;
        }

        public Set(int size)
        {
            this.capacity = size;
            this.elements = new double[capacity];
            this.count = 0;
        }

        public void Add(double elem)
        {
            if (Contains(elem))
                return; 

            if (count == capacity)
                throw new InvalidOperationException("The set is full.");

            elements[count++] = elem;
        }

        public void Remove(double elem)
        {
            int index = IndexOf(elem);
            if (index == -1)
                throw new InvalidOperationException("Element not found in the set.");

            
            for (int i = index; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            count--;
        }

        public bool Contains(double elem)
        {
            return IndexOf(elem) != -1;
        }

        private int IndexOf(double elem)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i] == elem)
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public int Length()
        {
            return count;
        }

        public int GetSize()
        {
            return capacity;
        }

        public void Print()
        {
            Console.Write("{ ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(elements[i]);
                if (i < count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
}
