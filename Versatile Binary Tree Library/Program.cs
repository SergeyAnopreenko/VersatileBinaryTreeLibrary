using System;

class Program
{
    static void Main(string[] args)
    {
        var binaryTree = new BinaryTree<int>();

        binaryTree.Add(8);
        binaryTree.Add(3);
        binaryTree.Add(10);
        binaryTree.Add(1);
        binaryTree.Add(6);
        binaryTree.Add(4);
        binaryTree.Add(7);
        binaryTree.Add(14);
        binaryTree.Add(16);

        binaryTree.PrintTree();

        Console.WriteLine(new string('-', 40));
        binaryTree.Remove(3);
        binaryTree.PrintTree();

        Console.WriteLine(new string('-', 40));
        binaryTree.Remove(8);
        binaryTree.PrintTree();

        Console.ReadLine();
    }
}