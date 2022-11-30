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
           
            Console.Write("Original Linked List: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }

            L.RemoveLast();
            Console.WriteLine();
            Console.Write("Linked List after deletion: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
        }
        }
    }
