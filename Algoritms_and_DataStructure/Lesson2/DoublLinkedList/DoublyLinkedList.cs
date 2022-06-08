namespace Algoritms_and_DataStructure.Lesson2;

public class DoublyLinkedList : ILinkedList
{
    private Node _head;
    private Node _tail;
    private int count;

    public int GetCount() => count;
    
    public void AddNode(int value)
    {
        Node node = new Node(value);
        if (_head == null)
        {
            node.Index = 0;
            _head = node;
        }
        else
        {
            var newIndexNode = _tail.Index;
            newIndexNode++;
            node.Index = newIndexNode;
            _tail.NextNode = node;
            node.PrevNode = _tail;
        }

        _tail = node;
        count++;
    }
     
    public void AddNodeAfter(Node node, int value)
    {
        var newNode = new Node(value);
        var nextItem = node.NextNode;
        var prevItem = nextItem.PrevNode;
        node.NextNode = newNode; 
        newNode.NextNode = nextItem;
        newNode.PrevNode = prevItem;
    }

    public void RemoveNode(int index)
    {
        var currentNode = _head;

        while (currentNode != null)
        {
            if (currentNode.Index.Equals(index))
            {
                break;
            }

            currentNode = currentNode.NextNode;
        }

        if (currentNode != null)
        {
            if (currentNode.NextNode != null)
            {
                currentNode.NextNode.PrevNode = currentNode.PrevNode;
            }
            else
            {
                _tail = currentNode.PrevNode;
            }

            if (currentNode.PrevNode != null)
            {
                currentNode.PrevNode.NextNode = currentNode.NextNode;
            }
            else
            {
                _head = currentNode.NextNode;
            } 

            count--;

        }
        
    }

    public void PrintNode()
    {
        var currentNode = _head;
        while (currentNode != null)
        {
            Console.WriteLine($"Value = {currentNode.Value}  " +
                              $"Index = {currentNode.Index}");
            currentNode = currentNode.NextNode;
        }
    }

    public void RemoveNode(Node node)
    {
        if (node != null)
        {
            if (node.NextNode != null)
            {
                node.NextNode.PrevNode = node.PrevNode;
            }
            else
            {
                _tail = node.PrevNode;
            }

            if (node.PrevNode != null)
            {
                node.PrevNode.NextNode = node.NextNode;
            }
            else
            {
                _head = node.NextNode;
            }
            
            count--;
        }
    }

    public Node FindNode(int searchValue)
    {
        var currentNode = _head;
        while (currentNode != null)
        {
            if (currentNode.Value.Equals(searchValue))
            {
                return currentNode;
            }

            currentNode = currentNode.NextNode;
        }
        
        return new Node(-1);
    }
}