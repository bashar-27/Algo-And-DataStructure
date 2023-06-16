using System;

namespace CodeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
                int []revArray=  RevArr(arr);
            Console.WriteLine("Array Before Reverse: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n\nArray After Reverse: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(revArray[i]+" ");
            }
        }

        public static int[] RevArr(int[] arr)
        {
            
            int size = arr.Length;
            if (size == 0)
            {
                return null;
            }
            int[] newArr = new int[size];
            int index = 0;
            for (int i = size-1; i>=0 ; i-- )
            {
                newArr[index] = arr[i];

                index++;
            }
            return newArr;
        }
    }
}
