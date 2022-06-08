using System.Runtime.CompilerServices;

namespace Algoritms_and_DataStructure.Lesson4.BinaryTree;

public interface ITree
{
    TreeNode GetRoot { get; }
    void AddItem(int value); //add tree node
    void RemoveItem(int value); //remove tree node
    void FindNodeByValue(int value);
    void PrintTree();
}