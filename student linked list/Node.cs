namespace student_linked_list;

public class Node
{
    public Student Data { get; set; }
    public Node Next { get; set; }

    public Node(Student data)
    {
        Data = data;
        Next = null;
    }
}