using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.BST
{

    internal class BSTInsertion
    {
        Node root;

        public BSTInsertion()
        {
            root = null;
        }

        public void Insert(Node temproot, int e)
        {
            Node temp = null;
            while (temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                {
                    return;
                }
                else if (e < temproot.element)
                {
                    temproot = temproot.left;
                }
                else if (e > temproot.element)
                {
                    temproot = temproot.right;
                }
            }
            Node n = new Node(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            else
            {
                root = n;
            }

        }

        // Inorder traversale
        public void Inorder(Node temproot)
        {
            if (temproot != null)
            {
                Inorder(temproot.left);
                Console.Write(temproot.element + " ");
                Inorder(temproot.right);
            }
        }

        static void Main(string[] args)
        {
            BSTInsertion insertion = new BSTInsertion();
            insertion.Insert(insertion.root, 50);
            insertion.Insert(insertion.root, 30);
            insertion.Insert(insertion.root, 80);
            insertion.Insert(insertion.root, 10);
            insertion.Insert(insertion.root, 40);
            insertion.Insert(insertion.root, 60);
            insertion.Insert(insertion.root, 90);
            Console.WriteLine("Inorder Traversal");
            insertion.Inorder(insertion.root);
            Console.WriteLine();

        }
    }
}
