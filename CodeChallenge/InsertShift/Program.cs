using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {



        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 16, 32, 25, 74, 20 };
            int[] arrStored = InsertionSort(arr);
            for (int i = 0; i < arrStored.Length; i++)
            {
                Console.Write(arrStored[i]+" ");
            }
            Console.WriteLine();


        }
        public static int[] InsertionSort(int[] arr)
        {
            int key, x;
            for (int i = 0; i < arr.Length; i++)
            {
                key = arr[i];
                x = i - 1;
                while (x >= 0 && arr[x] > key)
                {
                    arr[x + 1] = arr[x];
                    x--;
                }
                arr[x+1] = key;

            }
            return arr;
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



    
