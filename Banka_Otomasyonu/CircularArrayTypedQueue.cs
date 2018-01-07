using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class CircularArrayTypedQueue : IQueue
    {
        private Musteri[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new Musteri[size];
        }
        public void Insert(Musteri o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;


            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++;
        }

        public Musteri Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            Musteri temp = Queue[front];
            Queue[front] = null;

            
            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;

            return temp;
        }

        public Musteri Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
