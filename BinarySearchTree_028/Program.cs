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

        }
    }
    {
        static void Main(string[] args)
        {
        }
    }
} 
