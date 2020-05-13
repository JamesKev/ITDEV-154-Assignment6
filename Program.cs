using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST  = new BinarySearchTree();

            BST.insert(30); 
            BST.insert(50); 
            BST.insert(20); 
            BST.insert(40); 
            BST.insert(70); 
            BST.insert(60); 
            BST.insert(80); 
    
            // print inorder traversal of the BST 
            BST.inorder(); 



            Console.WriteLine("\nDelete 20"); 
            BST.deleteKey(20); 
            Console.WriteLine("Inorder traversal of the modified tree"); 
            BST.inorder(); 
        }
    }
}
