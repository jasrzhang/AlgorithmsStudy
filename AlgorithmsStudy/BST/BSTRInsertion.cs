using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.BST
{

    internal class BSTRInsertion
    {
        Node root;
        public BSTRInsertion()
        {
            root = null;
        }

        // using recursive method
        public Node Insert(Node temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                {
                    temproot.left = Insert(temproot.left, e);
                }
                else if (e > temproot.element)
                {
                    temproot.right = Insert(temproot.right, e);
                }
            }
            else
            {
                Node node = new Node(e, null, null);
                temproot = node;
            }
            return temproot;
        }

        public void Inorder(Node temproot)
        {
            if (temproot != null)
            {
                Inorder(temproot.left);
                Console.Write(temproot.element + " ");
                Inorder(temproot.right);
            }
        }

        public void Preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                Preorder(temproot.left);
                Preorder(temproot.right);
            }
        }

        public void Postorder(Node temproot)
        {
            if (temproot != null)
            {
                Preorder(temproot.left);
                Preorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }

        public void Levelorder()
        {
            Queue<Node> queue = new Queue<Node>();
            Node tRoot = root;
            Console.Write(tRoot.element + " ");
            queue.Enqueue(tRoot);
            while (queue.Count > 0)
            {
                tRoot = (Node)queue.Dequeue();
                if (tRoot.left != null)
                {
                    Console.Write(tRoot.left.element + " ");
                    queue.Enqueue(tRoot.left);
                }
                if (tRoot.right != null)
                {
                    Console.Write(tRoot.right.element + " ");
                    queue.Enqueue(tRoot.right);
                }
            }
        }

        // Iratative search
        public bool Search(int key)
        {
            Node temproot = root;
            while (temproot != null)
            {
                if (key == temproot.element)
                {
                    return true;
                }
                else if (key < temproot.element)
                {
                    temproot = temproot.left;
                }
                else if (key > temproot.element)
                {
                    temproot = temproot.right;
                }
            }
            return false;
        }
        // Recursive search
        public bool RSearch(Node troot, int key)
        {
            Node temproot = troot;
            if (temproot != null)
            {
                if (temproot.element == key)
                {
                    return true;
                }
                else if (key < temproot.element)
                {
                    return RSearch(temproot.left, key);
                }
                else if (key > temproot.element)
                {
                    return RSearch(temproot.right, key);
                }
            }

            return false;

        }

        public bool Delete(int e)
        {
            Node p = root;

            // Reference of grand parent
            Node pp = null;

            // Step 1. Find the Node and its parent node
            while (p != null && p.element != e)
            {
                pp = p;
                if (e < p.element)
                    p = p.left;
                else
                    p = p.right;

            }
            //Element not found
            if (p == null)
            {
                return false;
            }

            // Senario The deleting Node has both left and right subtree
            if (p.left != null && p.right != null)
            {
                // Strategy: Choose largest from left subtree (or can use smallest from the right subtree)

                // Left subtree
                Node s = p.left;
                // subtree's parent
                Node ps = p;

                // find the largest Node if(in) right subtree
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }

                // Only assign value here, keep the relationship
                p.element = s.element;
                // update reference to the parent and grand parent to the repalcement node
                p = s;
                pp = ps;
            }

            // Deletion logic, covers senario with leaf node, and only has one node
            Node c = null;
            // p.right should be alway null as sought by above step.
            if (p.left != null)
            {
                c = p.left;
            }
            else
            {
                c = p.right;
            }
            // check if the deleting node is root
            if (p == root)
                root = null;
            else
            {
                if (p == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }
            return true;
        }

        static void Main(string[] args)
        {
            BSTRInsertion insertion = new BSTRInsertion();
            insertion.root = insertion.Insert(insertion.root, 50);
            insertion.Insert(insertion.root, 30);
            insertion.Insert(insertion.root, 80);
            insertion.Insert(insertion.root, 10);
            insertion.Insert(insertion.root, 40);
            insertion.Insert(insertion.root, 60);
            insertion.Insert(insertion.root, 90);
            Console.WriteLine("Inorder Traversal");
            insertion.Inorder(insertion.root);
            Console.WriteLine();

            Console.WriteLine("Preorder Traversal");
            insertion.Preorder(insertion.root);
            Console.WriteLine();

            Console.WriteLine("Postorder Traversal");
            insertion.Postorder(insertion.root);
            Console.WriteLine();

            Console.WriteLine("Level Traversal");
            insertion.Levelorder();
            Console.WriteLine();

            insertion.Delete(50);
            Console.WriteLine("Inorder Traversal");
            insertion.Inorder(insertion.root);
            Console.WriteLine();

            Console.WriteLine("Iterative Search result 60, expected True: " + insertion.Search(60));
            Console.WriteLine("Iterative Search result 70, expected False:" + insertion.Search(70));
            Console.WriteLine("Recursive Search result 60, expected True :" + insertion.RSearch(insertion.root, 60));
            Console.WriteLine("Recursive Search result 70, expected False :" + insertion.RSearch(insertion.root, 70));

            Console.WriteLine();

        }
    }

}
