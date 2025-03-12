public class Node{
    public object element;
    public Node link;
    public Node(object element){
        this.element = element;
        this.link = null;
    }
}
public class LinkedList{
    public Node head;
    public LinkedList(){
        head = new Node("Header");
    }
    public Node Find(object item){
        Node current = head;
        while(current.element != item){
            current = current.link;
        }
        return current;
    }
    public void Insert(object newel, object afterel){
        Node current = Find(afterel);
        Node newnode = new Node(newel);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrev(object item){
        Node current = head;
        while(current.link != null && current.link.element != item){
            current = current.link;
        }
        return current;
    }
    public void Remove(object item){
        Node current = FindPrev(item);
        if(current.link != null){
            current.link = current.link.link;
        }
    }
    public void Print(){
        Node current = head;
        while(current != null){
            Console.WriteLine(current.element);
            current = current.link;
        }
    }
    public int Count(){
        int c = 0;
        Node current = head.link;
        while(current!=null){
            c++;
            current = current.link;
        }
        return c;
    }
    public int Sum(){
        int s = 0;
        Node current = head.link;
        while(current!=null){
            s += int.Parse(current.element.ToString());
            current = current.link;
        }
        return s;
    }
    //Thêm hàm swap và sort.
}
//Cài đặt DoubleLinkedList và bổ sung Count, Sum, Swap, Sort.
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        LinkedList list = new LinkedList();
        list.Insert("1", "Header");
        list.Insert("2", "1");
        list.Insert("3", "2");
        list.Print();
        Console.WriteLine("Count: " + list.Count());
        Console.WriteLine("Sum: " + list.Sum());
    }
}