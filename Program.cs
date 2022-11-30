namespace Day14_LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(56);
            L.AddFirst(30);
            L.AddFirst(70);
           
            Console.Write("Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
        }
    }
}