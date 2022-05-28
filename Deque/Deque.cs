using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    internal class Deque<T> : IEnumerable<T>
    {
        private class DoublyNode
        {
            public DoublyNode(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public DoublyNode Previous { get; set; }
            public DoublyNode Next { get; set; }
        }

        DoublyNode head; // головной/первый элемент
        DoublyNode tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента(с начала/ с конца)
        public void AddLast(T data)
        {
            DoublyNode node = new DoublyNode(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode node = new DoublyNode(data);
            DoublyNode temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public T RemoveFirst()
        {
            if (count == 0)
            {
                Console.WriteLine("Дек пуст");
                return default(T);
                //throw new InvalidOperationException();
            }
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }
        public T RemoveLast()
        {
            //if (count == 0)
            //    Console.WriteLine("Дек пуст");
            //    return default(T);


            if (count == 0)
            {
                Console.WriteLine("Дек пуст");
                return default(T);
                //throw new InvalidOperationException();
            }


            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
        }
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
