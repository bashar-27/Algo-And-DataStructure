using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class tree
    {
        //private Node root;
        public Node root { get; set; }

        public tree()
        {
            root = null;
        }
        public tree(Node root)
        {
            this.root = root;
        }
    }



    public class bTree : tree
    {
        public List<int> PreOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;

            results.Add(root.Data);

            if (root.left != null)
            {
                results.AddRange(PreOrder(root.left));
            }

            if (root.right != null)
            {
                results.AddRange(PreOrder(root.right));
            }

            return results;
        }

       
        /// <param name="root">Root Node of Binary Tree</param>
        /// <returns>IList of tree values</returns>
        public List<int> InOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;

            if (root.left != null)
            {
                results.AddRange(InOrder(root.left));
            }

            results.Add(root.Data);

            if (root.right != null)
            {
                results.AddRange(InOrder(root.right));
            }

            return results;
        }

   
        /// <param name="root">Rood Node of Binary Tree</param>
        /// <returns>IList of tree values</returns>
        public List<int> PostOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;
            if (root.left != null)
            {
                results.AddRange(PostOrder(root.left));
            }

            if (root.right != null)
            {
                results.AddRange(PostOrder(root.right));
            }

            results.Add(root.Data);

            return results;
        }
       
        public List<int>BFS(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            List <int> results = new List<int>();

            if(root == null) return results;

            queue.Enqueue(root);
            while(queue.Count != 0)
            {
                Node newNode = queue.Dequeue();
                results.Add(newNode.Data);
                if(newNode.left != null)
                {
                    queue.Enqueue(newNode.left);
                }
                if(newNode.right != null)
                {
                    queue.Enqueue(newNode.right);
                }
            }
            return results;

        }
        public int Max_tree()
        {
            return Max_tree(root);
        }
        private int Max_tree(Node root)
        {
            if (root == null) {
                return 0;
            }
            else
            {
                int max = root.Data;
                int lMax = Max_tree(root.left);
                int rMax = Max_tree(root.right);
                if (max <lMax )
                {
                    max = lMax;
                }
                if (max < rMax)
                {
                    max = rMax;
                    
                }
                return max;

            }

        }

    }

  }

