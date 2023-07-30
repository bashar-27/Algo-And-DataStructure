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
        public IList<int> PreOrder(Node root)
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
        public IList<int> InOrder(Node root)
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
        public IList<int> PostOrder(Node root)
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

    }

  }

