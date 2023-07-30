using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {



        static void Main(string[] args)
        {

            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            testTree.Add(300);
            testTree.Add(60);
            testTree.Add(90);
            testTree.Add(342);
            Console.WriteLine(testTree.Contains(90));
            Console.WriteLine(testTree.Contains(1));
            IList<int> results = testTree.PreOrder(testTree.root);
            IList<int> results2 = testTree.PostOrder(testTree.root);
            IList<int> results3 = testTree.InOrder(testTree.root);
            Console.WriteLine("--------------PreOrder-------------");
            foreach (int item in results)
            {
                Console.Write(item+" ");

            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------PostOrder------------");
            foreach (int item in results2)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------InOrder--------------");
            foreach (int item in results3)
                {
                    Console.Write(item + " ");


                }
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Maximum element in tree is " + testTree.Max_tree());

        }







        }
    }



    
