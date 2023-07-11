using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User : IDisposable
    {
        public int node1 { get; set; }

        public User() 
        {
            var linkedList = new MyLinkedList<int>();

            var node1 = linkedList.Add(100);
            var node2 = linkedList.Add(40);

            Console.WriteLine(node1.Value);
            Console.WriteLine(node2.Value);
        }

        ~User()
        {
            Console.WriteLine($"Объктов {node1}");
        }

        public void Dispose()
        {
            Console.WriteLine($"Объектов {node1} высбождено");
        }
    }
}
