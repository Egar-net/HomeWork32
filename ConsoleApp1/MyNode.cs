using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class MyNode<T>
    {
        public T Value { get; set; }
        public MyNode<T> Next { get; set; }
        public MyNode<T> Previous { get; set; }

        public MyNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
