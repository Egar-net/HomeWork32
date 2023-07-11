namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList<int>();

            var node1 = linkedList.Add(1);


            Console.WriteLine(node1.Value);
        }
    }
}