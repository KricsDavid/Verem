using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    public class FIFO
    {
        private double[] queue;
        private int front;
        private int rear;
        private int capacity;
        private int count;

        public FIFO()
        {
            this.capacity = 50;
            this.queue = new double[capacity];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }

        public FIFO(int size)
        {
            this.capacity = size;
            this.queue = new double[capacity];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }

        public void Push(double elem)
        {
            if (count == capacity)
                throw new InvalidOperationException(" A sor megtelt");

            rear = (rear + 1) % capacity;
            queue[rear] = elem;
            count++;
        }

        public double Pop()
        {
            if (count == 0)
                throw new InvalidOperationException("A sor üres");

            double elem = queue[front];
            front = (front + 1) % capacity;
            count--;
            return elem;
        }

        public void Clear()
        {
            front = 0;
            rear = -1;
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

        public void Reverse()
        {
            if (count <= 1) return;

            double[] reversedQueue = new double[capacity];
            for (int i = 0; i < count; i++)
            {
                reversedQueue[i] = queue[(rear - i + capacity) % capacity];
            }

            queue = reversedQueue;
            front = 0;
            rear = count - 1;
        }

        public void Sort()
        {
            if (count <= 1) return;

            double[] tempArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = queue[(front + i) % capacity];
            }

            Array.Sort(tempArray);

            for (int i = 0; i < count; i++)
            {
                queue[(front + i) % capacity] = tempArray[i];
            }
        }
    }
}

