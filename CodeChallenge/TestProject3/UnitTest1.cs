using System;
using Xunit;
using System.Runtime;
using InsertShift;
using System.Collections.Generic;



namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

           LinkedList list = new LinkedList();
            Assert.Null(list.Head);


        }
        [Fact]
        public void Test2()
        {

            LinkedList list = new LinkedList();
            list.Insert(5);
            Assert.NotNull(list.Head);
            Assert.Equal(5, list.Head.Data);
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            Assert.NotNull(linkedList.Head);
            Assert.Equal(5, linkedList.Head.Data);
        }

        [Fact]
        public void CanInsertMultipleNodes()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            Assert.NotNull(linkedList.Tail);
            Assert.Equal(15, linkedList.Tail.Data);
        }

        [Fact]
        public void IncludesReturnsTrueWhenValueExists()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            bool exists = linkedList.Include(10);
            Assert.True(exists);
        }


        [Fact]
        public void IncludesReturnsFalseWhenValueDoesNotExist()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            bool exists = linkedList.Include(20);
            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            string expected = "{5}->{10}->{15}->NULL ";
            string result = list.ToString();
            Assert.Equal(expected, result);
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
