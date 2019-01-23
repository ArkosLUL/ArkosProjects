using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AlgStr2Pavliuk
{
    [Serializable]
    public class Deque<T> : IEnumerable<T>
    {
        DoublyNode<T> head; // головной/первый элемент
        DoublyNode<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке
        // добавление элемента
        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

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
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
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
                throw new InvalidOperationException();
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
            if (count == 0)
                throw new InvalidOperationException();
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
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
   /*     static T CreateCopy<T>(T aobject)
        {

            System.Reflection.MethodInfo memberwiseClone = aobject.GetType().GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
            T Copy = (T)memberwiseClone.Invoke(aobject, null);
            foreach (FieldInfo f in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                object Source = f.GetValue(aobject);
                f.SetValue(Copy, CreateCopy(Source));
            }
            return Copy;

        }*/
        public  void Copy(Deque<T> Source)
        {
            if (Source.IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            //      Deque<T> copy = new Deque<T>();
            this.Clear();
            List<T> temp = new List<T>();
            foreach (var node in Source)
            {
                temp.Add(node);
            }
      //      temp.Reverse();
            foreach (var node in temp)
            {
                this.AddLast(node);
            }
        }
        public void Unite(Deque <T> SecondHalf)
        {
            while(!IsEmpty)
            {
                SecondHalf.AddFirst(RemoveFirst());
            }
            head = SecondHalf.head;
        }
        public void Divide(int elemNumber)
        {
            Stack<T> dividedPart = new Stack<T>();
            if (elemNumber >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < elemNumber; i++)
                {
                    dividedPart.Push(RemoveFirst());
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}