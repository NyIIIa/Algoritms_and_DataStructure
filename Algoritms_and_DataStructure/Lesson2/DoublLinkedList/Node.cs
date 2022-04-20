namespace Algoritms_and_DataStructure.Lesson2;

public class Node
{
    public int Value { get; set; }
    public Node NextNode { get; set; }
    public Node PrevNode { get; set; }
    public int Index { get; set; }
    public Node(int value)
    {
        Value = value;
    }

}