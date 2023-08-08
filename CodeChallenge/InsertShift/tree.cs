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

        //    public List<object> FizzBuzzTree(Node node)
        //    {
        //        List<object> list = new List<object>();
        //        if(node == null)
        //        {
        //            return list;
        //        }
        //        Queue<Node>fizzBuzzQueue = new Queue<Node>();
        //        fizzBuzzQueue.Enqueue(node);
        //        while(fizzBuzzQueue.Count > 0)
        //        {
        //            for (int i = 0; i < fizzBuzzQueue.Count; i++)
        //            {
        //                if (fizzBuzzQueue.First().Data % 5 == 0 && fizzBuzzQueue.First().Data % 3 == 0)
        //                {
        //                    list.Add("FizzBuzz");
        //                        }
        //                else if(fizzBuzzQueue.First().Data % 5 == 0)
        //                {
        //                    list.Add("Buzz");
        //                }
        //                else if(fizzBuzzQueue.First().Data %3== 0)
        //                {
        //                    list.Add("Fizz");
        //                }
        //                else
        //                {
        //                    list.Add(fizzBuzzQueue.First().Data);
        //                }
        //                Node node2 =fizzBuzzQueue.Dequeue();
        //                foreach (var item in node2.child)
        //                {
        //                    fizzBuzzQueue.Enqueue(item);
        //                }


        //            }
        //        }
        //        return list;
        //    }
        public BinarySearchTree FizzBuzzTree(BinarySearchTree tree)
        {
          //  List<Node> results = new List<Node>();
            PreOrder(tree.root);
            return tree;
        }

        /// <summary>
        /// Method validates the node value and replace with Fizz, Buzz, or FizzBuzz
        /// </summary>
        /// <param name="node"> Validating Node </param>
        /// <returns> Node with validated value </returns>
        public static Node CheckForNode(Node node)
        {
            List<Node>result = new List<Node>();
            if (node.Data % 15 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "FizzBuzz";
                n1.left = node.left;
                n1.right = node.right;
                result.Add(n1);
                return n1;
            }
            else if (node.Data % 5 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "Fizz";
                n1.left = node.left;
                n1.right = node.right;
                result.Add(n1);
                return n1;
            }
            else if (node.Data % 3 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "Buzz";
                n1.left = node.left;
                n1.right = node.right;
                result.Add(n1);
                return n1;
            }

            return node;
        }

        /// <summary>
        /// Method to check for every Nodes in a binary tree
        /// </summary>
        /// <param name="root">Root node checking for leftchild and rightchild</param>
        public void PreOrderr(Node root)
        {
            CheckForNode(root);
            if (root.left != null)
            {
                PreOrder(root.left);
            }
            if (root.right != null)
            {
                PreOrder(root.right);
            }
        }

    }

  }

