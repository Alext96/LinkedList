public class Node
{
    public Node next;
    public Object data;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add First:");
        LinkedList myList1 = new LinkedList();

        myList1.AddFirst("Hej");
        myList1.AddFirst("Cool");
        myList1.AddFirst("Test");
        myList1.printAllNodes();

        Console.WriteLine();

        Console.WriteLine("Add Last:");
        LinkedList myList2 = new LinkedList();

        myList2.AddLast("Hej");
        myList2.AddLast("Cool");
        myList2.AddLast("Test");
        myList2.printAllNodes();

        Console.ReadLine();
    }
}