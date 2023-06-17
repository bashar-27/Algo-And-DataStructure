using System;

namespace InsertShift
{
   public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10,20,40,50 };
            Console.WriteLine("Please insert new element");
            int element = Convert.ToInt32(Console.ReadLine());

            int []newArr= shiftArr(arr,element);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");

            }
        }

        public static int [] shiftArr(int[] arr,int element)
        {
            if (arr.Length == 0)
            {
                return null;
            }

            int[] shiftingArr = new int[arr.Length + 1];
            int middleIndex = arr.Length / 2;
            int elementArr = 0;
            
            for (int i =0; i < shiftingArr.Length; i++)
            {
                if(i == middleIndex)
                {
                    shiftingArr[i] = element;
                }
                else
                {

                shiftingArr[i] = arr[elementArr];
                elementArr++;
                }
            }
            return shiftingArr;
        }
    }
}
