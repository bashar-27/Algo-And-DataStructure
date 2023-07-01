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
        public void BeforeMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.InsertBefore(10, 7);
            string expected = "{5}->{7}->{10}->{15}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BeforeFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.InsertBefore(5, 2);
            string expected = "{2}->{5}->{10}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.InsertAfter(10, 12);
            string expected = "{5}->{10}->{12}->{15}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterLast()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.InsertAfter(10, 13);
            string expected = "{5}->{10}->{13}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }
    }
}
