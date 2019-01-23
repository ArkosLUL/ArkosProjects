using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgStrLab2KosogovArtemPZ_17_1
{
    class Node<T>
    {

        T data;
        Node<T> next;

        public Node(T data)
        {
            this.Data = data;
        }

        public T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
