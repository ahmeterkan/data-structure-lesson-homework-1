using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class PriorityQueue : IQueue
    {
        private Musteri[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new Musteri[size];
        }
        public void Insert(Musteri o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (o.IslemSuresi > Queue[i].IslemSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public Musteri Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            Musteri temp = Queue[front];
            Queue[front] = null;
            front--;
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
