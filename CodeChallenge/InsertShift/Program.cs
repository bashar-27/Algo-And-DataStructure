using System;

namespace InsertShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 40, 50 };
            Console.WriteLine("Please insert new element");
            int element = Convert.ToInt32(Console.ReadLine());
            int left = 0, right = arr.Length - 1;
            Console.WriteLine(Binary(arr, left, right, element));

        }

        public static int Binary(int[] arr, int left, int right, int element)
        {
            Array.Sort(arr);
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == element)
                {
                    return middle;
                }
                if (arr[middle] > element)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}