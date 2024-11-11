using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    public class LIFO
    {
        private double[] stack; 
        private int top; 
        private int capacity; 

        
        public LIFO()
        {
            this.capacity = 50;
            this.stack = new double[capacity];
            this.top = -1;
        }

        
        public LIFO(int size)
        {
            this.capacity = size;
            this.stack = new double[capacity];
            this.top = -1;
        }

        
        public void Push(double elem)
        {
            
            stack[top++] = elem;
        }

      
        public double Pop()
        {
            
            return stack[top--];
        }

       
        public void Clear()
        {
            top = 0; 
        }

        
        public int Length()
        {
            return top + 1; 
        }

        
        public int GetSize()
        {
            return capacity; 
        }

        
        public void Reverse()
        {
            double[] reversedStack = new double[capacity];
            for (int i = 0; i <= top; i++)
            {
                reversedStack[i] = stack[top - i];
            }
            stack = reversedStack;
        }

       
        public void Sort()
        {
            for (int i = 0; i <= top; i++)
            {
                for (int j = 0; j < top - i; j++)
                {
                    if (stack[j] > stack[j + 1])
                    {
                        
                        double temp = stack[j];
                        stack[j] = stack[j + 1];
                        stack[j + 1] = temp;
                    }
                }
            }
        }
    }


}
