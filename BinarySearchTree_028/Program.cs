using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_028
{

    class Node
    {
        public string info;
        public Node Leftchild;
        public Node rightchild;
        //constructor for the Node Class

        public Node(string i, Node l, Node r)
        {
            info = i;
            Leftchild = l;
            rightchild = r;
        }
    }

    /* A node class consists of three things, the information
     * references to the right child, and references to the left child*/

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /* Initializing ROOt to null*/
        }
        public void search(string element, ref Node parents, ref Node currentNode)
        {
            /*Thisfunction searces the currentNode of the specified Node as well as the current Node of its parents*/
            currentNode = ROOT;
            parents = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parents = currentNode;
                if (string.Compare(element, currentNode.info) > 0)
                    currentNode = currentNode.Leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element)
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/*check if the node to be inserted already*inserted or not*/
            {
                Console.WriteLine("duplicate words not allowed");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.Leftchild = tmp;
                    parent.rightchild = tmp;
                }
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                inorder(ptr.Leftchild);
                inorder(ptr.rightchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + "");
                preorder(ptr.Leftchild);
                preorder(ptr.rightchild);
            }
        }
        public void postorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                postorder(ptr.Leftchild);
                postorder(ptr.rightchild);
            }
        }

        static void Main(string[] args)
        {
            Program x = new Program();
            while (true)
            {
                Console.WriteLine("\n Menu ");
                Console.WriteLine("1. Implement insert option");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Enter your choice (1-5)");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                        }
                        string word = Console.ReadLine();
                        x.insert(word);
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preorder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postorder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                                break;
                        }
                }
            }
        } 
    }
}