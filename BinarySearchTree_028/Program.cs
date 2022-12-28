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
            Node tap, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode!= null)/*check if the node to be inserted already*inserted or not*/
            {
                Console.WriteLine("duplicate words not allowed");
                return
            }
        }
