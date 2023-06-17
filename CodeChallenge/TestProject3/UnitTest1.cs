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
            int[] shiftArray = { 1, 2, 30, 3, 4 };
            int[] result = Program.shiftArr(arr, ele);
            Assert.Equal(result, shiftArray);

        }
        [Fact]
        public void Test2()
        {
            int ele = 30;
            int[] arr = { };
            int[] shiftArray = null;
            int[] result = Program.shiftArr(arr, ele);
            Assert.Equal(result, shiftArray);

        }
    }
}
