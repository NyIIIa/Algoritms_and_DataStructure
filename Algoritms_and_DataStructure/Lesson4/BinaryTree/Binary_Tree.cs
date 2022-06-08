using BenchmarkDotNet.Attributes;

namespace Algoritms_and_DataStructure.Lesson4.BinaryTree;

public class Binary_Tree : ITree, IBFS, IDFS
{
    private TreeNode _root;  // left less, right more
    public TreeNode GetRoot { get => _root; }
    public void AddItem(int value)
    {
        if (_root == null)
        {
            _root = new TreeNode {Value = value};
        }
        else
        {
            var tmpTreeNode = _root;
            while (tmpTreeNode != null)
            {
                if (value > tmpTreeNode.Value)
                {
                    if (tmpTreeNode.RightChild != null)
                    {
                        tmpTreeNode = tmpTreeNode.RightChild;
                    }
                    else
                    {
                        
                        tmpTreeNode.RightChild = new TreeNode{Value = value};
                        tmpTreeNode.RightChild.Parent = tmpTreeNode;
                        break;
                    }
                }
                else if(value < tmpTreeNode.Value)
                {
                    if (tmpTreeNode.LeftChild != null)
                    {
                        tmpTreeNode = tmpTreeNode.LeftChild;
                    }
                    else
                    {
                        tmpTreeNode.LeftChild = new TreeNode {Value = value};
                        tmpTreeNode.LeftChild.Parent = tmpTreeNode;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong tree state!");
                    break;
                }
            }
        }
    }
    public void RemoveItem(int value)
    {
        if (_root == null)
        {
            Console.WriteLine("tree doesn't exist");
        }
        else if (_root.Value == value)
        {
            Console.WriteLine("must not delete root tree");
        }
        else
        {
            if (value > _root.Value)
            {
                var tmpTreeNode = _root.RightChild;
                while (tmpTreeNode != null)
                {
                    if (tmpTreeNode.Equals(value))
                    {
                        if (tmpTreeNode.LeftChild == null && tmpTreeNode.RightChild == null)
                        {
                            tmpTreeNode.Parent.RightChild = null;
                        }
                        else if(tmpTreeNode.RightChild == null)
                        {
                            if (tmpTreeNode.LeftChild != null)
                            {
                                tmpTreeNode.Parent.RightChild = tmpTreeNode.LeftChild;
                            }
                            else
                            {
                                tmpTreeNode.Parent.RightChild = null;
                            }
                        }
                        else if(tmpTreeNode.LeftChild == null)
                        {
                            if (tmpTreeNode.RightChild != null)
                            {
                                tmpTreeNode.Parent.RightChild = tmpTreeNode.RightChild;
                            }
                            else
                            {
                                tmpTreeNode.Parent.RightChild = null;
                            }
                        }
                        else
                        {
                            tmpTreeNode.Parent.RightChild = tmpTreeNode.RightChild;
                            tmpTreeNode.RightChild.Parent = tmpTreeNode.Parent;
                            tmpTreeNode.LeftChild.Parent = tmpTreeNode.Parent;
                        }
                        
                    }

                    tmpTreeNode = tmpTreeNode.RightChild;

                }
            }
            if (value < _root.Value)
            {
                var tmpTreeNode = _root.LeftChild;
                while (tmpTreeNode != null)
                {
                    if (tmpTreeNode.Equals(value))
                    {
                        if (tmpTreeNode.LeftChild == null && tmpTreeNode.RightChild == null)
                        {
                            tmpTreeNode.Parent.LeftChild = null;
                        }
                        else if(tmpTreeNode.RightChild == null)
                        {
                            if (tmpTreeNode.LeftChild != null)
                            {
                                tmpTreeNode.Parent.RightChild = tmpTreeNode.LeftChild;
                            }
                            else
                            {
                                tmpTreeNode.Parent.RightChild = null;
                            }
                        }
                        else if(tmpTreeNode.LeftChild == null)
                        {
                            if (tmpTreeNode.RightChild != null)
                            {
                                tmpTreeNode.Parent.RightChild = tmpTreeNode.RightChild;
                            }
                            else
                            {
                                tmpTreeNode.Parent.RightChild = null;
                            }
                        }
                        else
                        {
                            tmpTreeNode.Parent.RightChild = tmpTreeNode.RightChild;
                            tmpTreeNode.RightChild.Parent = tmpTreeNode.Parent;
                            tmpTreeNode.LeftChild.Parent = tmpTreeNode.Parent;
                        }
                        
                    }

                    tmpTreeNode = tmpTreeNode.LeftChild;

                }
            }
        }
    }
    public void FindNodeByValue(int value)
    {
        if (_root == null)
        {
            Console.WriteLine("Tree empty");
        }
        else
        {
            bool findNode = false;
            var tmpNode = _root;
            while (tmpNode != null)
            {
                if(tmpNode.Value == value)
                {
                    if (tmpNode.LeftChild != null && tmpNode.RightChild != null)
                    {
                        Console.WriteLine($"Node <{tmpNode.Value}> LeftNode <{tmpNode.LeftChild.Value}> " +
                                          $"RightNode <{tmpNode.RightChild.Value}>");
                        findNode = true;
                        break;
                    }
                    else if(tmpNode.LeftChild == null && tmpNode.RightChild != null)
                    {
                        Console.WriteLine($"Node <{tmpNode.Value}> LeftNode <none> " +
                                          $"RightNode <{tmpNode.RightChild.Value}>");
                        findNode = true;
                        break;
                    }
                    else if(tmpNode.LeftChild != null && tmpNode.RightChild == null)
                    {
                        Console.WriteLine($"Node <{tmpNode.Value}> LeftNode <{tmpNode.LeftChild.Value}> " +
                                          $"RightNode <none>");
                        findNode = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Node <{tmpNode.Value}> LeftNode <none> RightNode <none>");
                        findNode = true;
                        break;
                    }
                }
                else if(tmpNode.Value > value)
                {
                    tmpNode = tmpNode.RightChild;
                }
                else if(tmpNode.Value < value)
                {
                    tmpNode = tmpNode.LeftChild;
                }
            }
            if (findNode != true)
            {
                Console.WriteLine("There is no node with this value in the tree");
            }
        }
        
    }
    public void PrintTree()
    {
        BTreePrinter.Print(_root);
    }
    public int BreadthFirstSearch(TreeNode root, int value)
    {
        var queueNods = new Queue<TreeNode>();
        if(root != null)
            queueNods.Enqueue(root);
        while (true)
        {
            if (queueNods.Count == 0) //пункт 2
                return -1;

            var node = queueNods.Dequeue(); //пункт 3

            if (node.Value == value) //пункт 4
                return node.Value;
            else
            {
                //пункт 5
                if (node.LeftChild != null)
                    queueNods.Enqueue(node.LeftChild);
                if (node.RightChild != null)
                    queueNods.Enqueue(node.RightChild);
            }
        }

    }
    public int DeepFirstSearch(TreeNode root, int value)
    {
        var stackNods = new Stack<TreeNode>();
        if (root != null)
            stackNods.Push(root);
        while (true)
        {
            if (stackNods.Count == 0)
                return -1;

            var node = stackNods.Pop();
            if (node.Value == value)
                return node.Value;
            else
            {
                if(node.LeftChild != null)
                    stackNods.Push(node.LeftChild);
                if (node.RightChild != null)
                    stackNods.Push(node.RightChild);
            }
        }
        
    }
}