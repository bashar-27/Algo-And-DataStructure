using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class BinarySearchTree:bTree
    {
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
            }
            Node current = root;
            Node parent = null;

            while (current != null)
            {
                if (value == current.Data)
                {
                    return;
                }
                else if (value < current.Data)
                {
                    parent = current;
                    current = current.left;
                }
                else
                {
                    parent = current;
                    current = current.right;
                }
            }

            if (value < parent.Data)
            {
                parent.left = newNode;
            }
            else
            {
                parent.right = newNode;
            }
        }

        /// <summary>
        /// Determines if a Binary Tree contains a value
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>True/False if found</returns>
        public bool Contains(int value)
        {
            Node current = root;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                else if (value < current.Data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return false;
        }

        public void AddBFS(int value)
        {
            root = AddRecursive(root, value);
        }

        private Node AddRecursive(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }


            if (current.left == null)
            {
                current.left = new Node(value);
            }

            else if (current.right == null)
            {
                current.right = new Node(value);
            }

            else
            {
                current.left = AddRecursive(current.left, value);
            }

            return current;
        }
    }
}
