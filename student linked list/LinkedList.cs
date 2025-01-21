namespace student_linked_list;

public class LinkedList
{
    private Node head;  //the first node in the list
    
    //method to add new student into end of the list

    public void Add(Student student)
    {
        Node newNode = new Node(student);
        if (head == null)
        {
            head = newNode; //if the list is empty set the newNode as head
        }
        Node currentNode = head;
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next; //traverse to the last node
        }
        currentNode.Next = newNode;  //at the new node at the end
    }
    
    //method to add new student at the beginning of the list

    public void InsertAtBeginning(Student student)
    {
        Node newNode = new Node(student);
        newNode.Next = head;
        head = newNode;
    }
    
    //method to insert a student at a given position
    public void InsertAtPosition(Student student, int position)
    {
        if (position < 0)
        {
            Console.WriteLine("Postiion cannot be negative");
        }
        Node newNode = new Node(student);
        
        //insert at begining if position is zero
        if (position == 0)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }
        Node currentNode = head;
        int currentPosition = 0;
        
        //traverse to the positon just before where the new node will be inserted
        while (currentNode != null && currentPosition < position - 1)
        {
            currentNode = currentNode.Next;
            currentPosition++;
        }
        
        //if the position is out of bounds print a message
        if (currentNode == null)
        {
            Console.WriteLine("Position is out of bounds");
            return;
        }
        
        //Insert the new node at the specific position
        newNode.Next = currentNode.Next;
        currentNode.Next = newNode;
    }
}