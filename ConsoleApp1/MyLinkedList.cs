using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyLinkedList<T> 
    {
        private List<MyNode<T>> nodes;

        public MyNode<T> First { get; private set; }
        public MyNode<T> Last { get; private set; }

        public MyLinkedList()
        {
            nodes = new List<MyNode<T>>();
            First = null;
            Last = null;
        }

        public MyNode<T> Add(T element)
        {
            var newNode = new MyNode<T>(element);

            nodes.Add(newNode);
            return newNode;
        }
    }
}
