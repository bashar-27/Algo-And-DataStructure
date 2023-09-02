using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {



        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int n = arr.Length;
            Console.WriteLine("Array before call function"); 
            Print(arr, n);
            int [] mergedArr = MergeSort(arr,0,n-1);
            Console.WriteLine("Array after call function"); 
            Print(mergedArr, n);
          

        }
        public static int[] Merge(int[] arr, int left, int mid, int right)
        {
            int i, j = 0;
            int k = left;
            int lArr = mid - left + 1;              //to find size left array
            int rArr = right - mid;                 //to find size right array
            int[] leftSubArr = new int[lArr];       //new sub left array with lArr size
            int[] rightSubArr = new int[rArr];      //new sub right array with rArr size

            for (i = 0; i < lArr; i++)
                leftSubArr[i] = arr[left + i];      //for fill new sub left array
            for (j = 0; j < rArr; j++)
                rightSubArr[j] = arr[mid + 1 + j];  //for fill new sub right array

            i = 0;
            j = 0;
            while (i < lArr && j < rArr)
            {
                if (leftSubArr[i] <= rightSubArr[j])
                {
                    arr[k] = leftSubArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightSubArr[j];
                    j++;
                }
                k++;
            }
            //if one side of array have no elements and other side still have an elements
            while (i < lArr)
            {
                arr[k] = leftSubArr[i];
                i++;
                k++;
            }
            while (j < rArr)
            {
                arr[k] = rightSubArr[j];
                j++;
                k++;
            }

            return arr;
        }

       
        public static int[] MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                arr = Merge(arr, left, mid, right);
            }

            return arr;
        }
    
    public static void Print(int[]arr ,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
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



    
