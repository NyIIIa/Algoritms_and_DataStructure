namespace Algoritms_and_DataStructure.Lesson4.BinaryTree;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode LeftChild { get; set; }
    public TreeNode RightChild { get; set; }
    
    public TreeNode Parent { get; set; }

    public override bool Equals(object? value)
    {
        if ((int)value < 0)
            return false;
        
        return (int)value == Value;

    }
}