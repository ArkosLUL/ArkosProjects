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

        public int Counter { get => counter;}
        public bool IsEmpty()
        {
            return Counter == 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = head;
            head = newNode;
            counter++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");    
            }
            
                Node<T> temp = head;
                head = head.Next;
                counter--;
            
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
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, aobject);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
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
            if(secondHalf == null || this == null)
            {
                throw new NullReferenceException("One of the stacks is empty");
            }
            while(!IsEmpty())
            {
                secondHalf.Push(Pop());
            }
        }

        public Stack<T> Divide(int elemNumber)
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
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
            return dividedPart;
        }

        public void DeleteStack()
        {
            this.head = null;
            counter = 0;
        }
        
    }
}
