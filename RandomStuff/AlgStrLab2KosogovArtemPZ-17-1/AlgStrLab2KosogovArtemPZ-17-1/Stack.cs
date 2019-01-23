using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AlgStrLab2KosogovArtemPZ_17_1
{
    class Stack<T> : IEnumerable<T>
    {
        Node<T> head;
        int counter;

        public int Counter { get => counter; set => counter = value; }

        public bool IsEmpty()
        {
            return Counter == 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = head;
            head = newNode;
            Counter++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");    
            }
            
                Node<T> temp = head;
                head = head.Next;
                Counter--;
            
            return temp.Data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        static T CreateCopy<T>(T aobject)
        {

            MethodInfo memberwiseClone = aobject.GetType().GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
            T Copy = (T)memberwiseClone.Invoke(aobject, null);
            foreach (FieldInfo f in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                object original = f.GetValue(aobject);
                f.SetValue(Copy, CreateCopy(original));
            }
            return Copy;

        }

        public static Stack<T> Copy(Stack<T> original)
        {
            if (original.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            Stack<T> copy = new Stack<T>();
            List<T> temp = new List<T>();
                foreach (var node in original)
                {
                    temp.Add(CreateCopy<T>(node));
                }
            temp.Reverse();
            foreach (var node in temp)
            {
                copy.Push(node);
            }
                return copy;
        }

        public void Concatenate(Stack<T> secondHalf)
        {
            
            while(!IsEmpty())
            {
                secondHalf.Push(Pop());
            }
            head = secondHalf.head;
        }

        public void Divide(int elemNumber)
        {
            Stack<T> dividedPart = new Stack<T>();
            if (elemNumber >= Counter)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < elemNumber; i++)
                {
                    dividedPart.Push(Pop());
                }
            }
        }

        
    }
}
