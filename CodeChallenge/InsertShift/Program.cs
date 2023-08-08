using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {



        static void Main(string[] args)
        {

            BinarySearchTree testTree = new BinarySearchTree();
            testTree.AddBFS(2);
            testTree.AddBFS(5);
            testTree.AddBFS(2);
            testTree.AddBFS(6);
            testTree.AddBFS(9);
            testTree.AddBFS(11);
            testTree.AddBFS(5);
            testTree.AddBFS(7);
            testTree.AddBFS(30);
            testTree.AddBFS(4);
            testTree.AddBFS(30);
            testTree.AddBFS(88);
            testTree.Add(342);

            Console.WriteLine(testTree.Contains(90));
            Console.WriteLine(testTree.Contains(1));
            Console.WriteLine("\n\n\nMaximum element in tree is " + testTree.Max_tree());
            IList<int> results = testTree.PreOrder(testTree.root);
            IList<int> results2 = testTree.PostOrder(testTree.root);
            IList<int> results3 = testTree.InOrder(testTree.root);
            List<int> results4 = testTree.BFS(testTree.root);
            List<string> fizzbuzzlist = FizzBuzzTree(testTree);



            Console.WriteLine("--------------PreOrder-------------");
            foreach (int item in results)
            {
                Console.Write(item + " ");

                }
                Console.WriteLine("\n\n\n");
            Console.WriteLine("--------------FizzBuzzed Tree PreOrder Traversal:--------------");

       
            foreach (var item in fizzbuzzlist)
            {
                Console.Write(item+" ");

            }
            Console.WriteLine("\n\n\n");

                //Console.WriteLine("\n");
                //Console.WriteLine("--------------PostOrder------------");
                //foreach (int item in results2)
                //{
                //    Console.Write(item + " ");

                //}
                //Console.WriteLine("\n");
                //Console.WriteLine("--------------InOrder--------------");
                //foreach (int item in results3)
                //{
                //    Console.Write(item + " ");


                //}
                //Console.WriteLine("\n\n\n");
                //Console.WriteLine("--------------BFS--------------");
                //foreach (int item in results4)
                //{
                //    Console.Write(item + " ");

                //}
        }
        public static List<string> FizzBuzzTree(BinarySearchTree tree)
        {
            List<string> resultList = new List<string>();
            PreOrderr(tree.root, resultList);
            return resultList;
        }


        /// <summary>
        /// Method to check for every Nodes in a binary tree
        /// </summary>
        /// <param name="root">Root node checking for leftchild and rightchild</param>
        public static void PreOrderr(Node root, List<string> result)
        {


            if (root != null)
            {
                if (root.Data % 15 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (root.Data % 3 == 0)
                {
                    result.Add("Fizz");

                }
                else if (root.Data % 5 == 0)
                {
                    result.Add("Buzz");

                }
                else
                {
                    result.Add(root.Data.ToString());
                }
                if(root.left != null)
                {
                    PreOrderr(root.left, result);
                }
               if (root.right != null)
                {

                PreOrderr(root.right, result);
                }
            }








        }
    }
}



    
