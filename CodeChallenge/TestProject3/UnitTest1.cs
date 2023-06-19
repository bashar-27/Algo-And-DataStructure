using System;
using Xunit;
using InsertShift;
namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int ele = 30;
            int[] arr = { 1, 2, 3, 4 };
            int start = 0;
            int len = arr.Length - 1;
                        int result = Program.Binary(arr,start,len, ele);
            Assert.Equal(result, -1);

        }
        [Fact]
        public void Test2()
        {
            int ele = 3;
            int[] arr = { 1, 2, 3, 4 };
            int start = 0;
            int len = arr.Length - 1;
            int result = Program.Binary(arr, start, len, ele);
            Assert.Equal(result, 2);

        }
        [Fact]
        public void Test3()
        {
            int ele = -1;
            int[] arr = { -1, -2, -3, -4 };
            int start = 0;
            int len = arr.Length - 1;
            int result = Program.Binary(arr, start, len, ele);
            Assert.Equal(result, 3);

        }

    }
}
