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
            testTree.AddBFS(7);
            testTree.AddBFS(5);
            testTree.AddBFS(2);
            testTree.AddBFS(6);
            testTree.AddBFS(9);
            testTree.AddBFS(5);
            testTree.AddBFS(11);
            testTree.AddBFS(4);
           // testTree.Add(342);
            Console.WriteLine(testTree.Contains(90));
            Console.WriteLine(testTree.Contains(1));
            IList<int> results = testTree.PreOrder(testTree.root);
            IList<int> results2 = testTree.PostOrder(testTree.root);
            IList<int> results3 = testTree.InOrder(testTree.root); 
            List<int> results4 = testTree.BFS(testTree.root);
            //Console.WriteLine("--------------PreOrder-------------");
            //foreach (int item in results)
            //{
            //    Console.Write(item+" ");

            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("--------------PostOrder------------");
            //foreach (int item in results2)
            //{
            //    Console.Write(item + " ");

            //}
            Console.WriteLine("\n");
            Console.WriteLine("--------------InOrder--------------");
            foreach (int item in results3)
            {
                Console.Write(item + " ");


            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("--------------BFS--------------");
            foreach (int item in results4)
            {
                Console.Write(item + " ");


            }

            Console.WriteLine("\n\n\nMaximum element in tree is " + testTree.Max_tree());

        }







        }
    }



    
