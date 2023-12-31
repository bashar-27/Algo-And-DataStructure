using System;
using Xunit;
using System.Runtime;
using InsertShift;
using System.Collections.Generic;



namespace TestProject3
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{

        //    LinkedList list = new LinkedList();
        //    Assert.Null(list.Head);


        //}
        //[Fact]
        //public void Test2()
        //{

        //    LinkedList list = new LinkedList();
        //    list.Insert(5);
        //    Assert.NotNull(list.Head);
        //    Assert.Equal(5, list.Head.Data);
        //}

        //[Fact]
        //public void HeadPointsToFirstNode()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    Assert.NotNull(linkedList.Head);
        //    Assert.Equal(5, linkedList.Head.Data);
        //}

        //[Fact]
        //public void CanInsertMultipleNodes()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    Assert.NotNull(linkedList.Tail);
        //    Assert.Equal(15, linkedList.Tail.Data);
        //}

        //[Fact]
        //public void IncludesReturnsTrueWhenValueExists()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    bool exists = linkedList.Include(10);
        //    Assert.True(exists);
        //}


        //[Fact]
        //public void IncludesReturnsFalseWhenValueDoesNotExist()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    bool exists = linkedList.Include(20);
        //    Assert.False(exists);
        //}

        //[Fact]
        //public void CanReturnAllValuesInLinkedList()
        //{
        //    LinkedList list = new LinkedList();
        //    list.Insert(5);
        //    list.Insert(10);
        //    list.Insert(15);
        //    string expected = "{5}->{10}->{15}->NULL";
        //    string result = list.ToString();
        //    Assert.Equal(expected, result);
        //}
        //[Fact]

        //public void BeforeMiddle()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    linkedList.InsertBefore(10, 7);
        //    string expected = "{5}->{7}->{10}->{15}->NULL";
        //    string result = linkedList.ToString();
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void BeforeFirst()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.InsertBefore(5, 2);
        //    string expected = "{2}->{5}->{10}->NULL";
        //    string result = linkedList.ToString();
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void AfterMiddle()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    linkedList.InsertAfter(10, 12);
        //    string expected = "{5}->{10}->{12}->{15}->NULL";
        //    string result = linkedList.ToString();
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void AfterLast()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.InsertAfter(10, 13);
        //    string expected = "{5}->{10}->{13}->NULL";
        //    string result = linkedList.ToString();
        //    Assert.Equal(expected, result);
        //}
        //[Fact]

        //public void zipTest()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    LinkedList linkedList2 = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(15);
        //    linkedList2.Insert(10);
        //    linkedList2.Insert(20);
        //    LinkedList linkedList3 =LinkedList.zipList(linkedList, linkedList2);
        //    string expected = "{5}->{10}->{15}->{20}->NULL";
        //      Assert.Equal(expected, linkedList3.ToString());
        //}
        //[Fact]
        //public void zipTest2()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    LinkedList linkedList2 = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(15);
        //    linkedList.Insert(25);
        //    linkedList2.Insert(10);
        //    linkedList2.Insert(20);
        //    LinkedList linkedList3 = LinkedList.zipList(linkedList, linkedList2);
        //    string expected = "{5}->{10}->{15}->{20}->{25}->NULL";
        //    Assert.Equal(expected, linkedList3.ToString());
        //}
        //[Fact]
        //public void zipTest3()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    LinkedList linkedList2 = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(15);
        //    linkedList.Insert(25);
        //    linkedList2.Insert(10);
        //    linkedList2.Insert(20);
        //    linkedList2.Insert(30);
        //    linkedList2.Insert(35);
        //    linkedList2.Insert(40);
        //    LinkedList linkedList3 = LinkedList.zipList(linkedList, linkedList2);
        //    string expected = "{5}->{10}->{15}->{20}->{25}->{30}->{35}->{40}->NULL";
        //    Assert.Equal(expected, linkedList3.ToString());
        //}
        //[Fact]
        //public void zipTest4()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    LinkedList linkedList2 = new LinkedList();
        //    linkedList2.Insert(10);
        //    linkedList2.Insert(20);
        //    linkedList2.Insert(30);
        //    linkedList2.Insert(35);
        //    linkedList2.Insert(40);
        //    LinkedList linkedList3 = LinkedList.zipList(linkedList, linkedList2);
        //    string expected = "{10}->{20}->{30}->{35}->{40}->NULL";
        //    Assert.Equal(expected, linkedList3.ToString());
        //}

        //public void KGreaterLength()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    linkedList.Insert(20);
        //    int k = 5;
        //    int result = linkedList.kthFromEnd(k);
        //    Assert.Equal(-1, result);
        //}
        //[Fact]
        //public void KEqualLength()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    linkedList.Insert(20);
        //    linkedList.Insert(25);
        //    linkedList.Insert(30);
        //    int k = 6;
        //    int result = linkedList.kthFromEnd(k);
        //    Assert.Equal(-1, result);


        //}
        //[Fact]
        //public void KNotPositive()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    int k = -5;
        //    int result = linkedList.kthFromEnd(k);
        //    Assert.Equal(-1, result);

        //}
        //[Fact]
        //public void KEqual1()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    int k = 1;
        //    int result = linkedList.kthFromEnd(k);
        //    Assert.Equal(5, result);

        //}
        //[Fact]
        //public void KHappy()
        //{
        //    LinkedList linkedList = new LinkedList();
        //    linkedList.Insert(5);
        //    linkedList.Insert(10);
        //    linkedList.Insert(15);
        //    int k = 2;
        //    int result = linkedList.kthFromEnd(k);
        //    Assert.Equal(5, result);

        //}
        //[Fact]
        //public void CanEnqueueAndDequeue()
        //{
        //    // Arrange
        //    Queue queue = new Queue();

        //    // Act
        //    queue.Enqueue(10);
        //    queue.Enqueue(20);
        //    int result1 = queue.Dequeue();
        //    int result2 = queue.Dequeue();

        //    // Assert
        //    Assert.Equal(10, result1);
        //    Assert.Equal(20, result2);
        //    Assert.True(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanPeek()
        //{
        //    // Arrange
        //    Queue queue = new Queue();
        //    queue.Enqueue(10);
        //    queue.Enqueue(20);

        //    // Act
        //    int result = queue.peek();

        //    // Assert
        //    Assert.Equal(10, result);
        //    Assert.False(queue.IsEmpty());

       
        //}

        //[Fact]
        //public void CanEnqueue()
        //{
        //    // Arrange
        //    Queue queue = new Queue();

        //    // Act
        //    queue.Enqueue(10);

        //    // Assert
        //    Assert.False(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanEnqueueMultipleValues()
        //{
        //    // Arrange
        //    Queue queue = new Queue();

        //    // Act
        //    queue.Enqueue(10);
        //    queue.Enqueue(20);

        //    // Assert
        //    Assert.False(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanDequeue()
        //{
        //    // Arrange
        //    Queue queue = new Queue();
        //    queue.Enqueue(10);

        //    // Act
        //    int result = queue.Dequeue();

        //    // Assert
        //    Assert.Equal(10, result);
        //    Assert.True(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanPeekStack()
        //{
        //    // Arrange
        //    Queue queue = new Queue();
        //    queue.Enqueue(10);

        //    // Act
        //    int result = queue.peek();

        //    // Assert
        //    Assert.Equal(10, result);
        //    Assert.False(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanEmptyQueue()
        //{
        //    // Arrange
        //    Queue queue = new Queue();
        //    queue.Enqueue(10);
        //    queue.Enqueue(20);

        //    // Act
        //    queue.Dequeue();
        //    queue.Dequeue();

        //    // Assert
        //    Assert.True(queue.IsEmpty());
        //}

        //[Fact]
        //public void CanInstantiateEmptyQueue()
        //{
        //    // Arrange & Act
        //    Queue queue = new Queue();

        //    // Assert
        //    Assert.True(queue.IsEmpty());
        //}

        //[Fact]
        //public void DequeueOnEmptyQueueRaisesException()
        //{
        //    // Arrange
        //    Queue queue = new Queue();

        //    // Act & Assert
        //    Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        //}

        //[Fact]
        //public void PeekOnEmptyQueueRaisesException()
        //{
        //    // Arrange
        //    Queue queue = new Queue();

        //    // Act & Assert
        //    Assert.Throws<InvalidOperationException>(() => queue.peek());
        //}


        //[Fact]
        //public void EnqDeq_HappyPath()
        //{
            
        //    PseudoQueue q = new PseudoQueue();

           
        //    q.Enqueue(10);
        //    q.Enqueue(20);
        //    q.Enqueue(30);
        //    int res1 = q.Dequeue();
        //    int res2 = q.Dequeue();
        //    q.Enqueue(40);
        //    int res3 = q.Dequeue();

        //    Assert.Equal(10, res1);
        //    Assert.Equal(20, res2);
        //    Assert.Equal(30, res3);
        //}

        //[Fact]
        //public void Deq_ExpectedFailure()
        //{
            
        //    PseudoQueue q = new PseudoQueue();

          
        //    Assert.Throws<InvalidOperationException>(() => q.Dequeue());
        //}

        //[Fact]
        //public void EnqDeq_ExpectedBehavior()
        //{
         
        //    PseudoQueue q = new PseudoQueue();

         
        //    q.Enqueue(10);
        //    int res1 = q.Dequeue();
        //    q.Enqueue(20);
        //    int res2 = q.Dequeue();

          
        //    Assert.Equal(10, res1);
        //    Assert.Equal(20, res2);
        //}
        [Fact]
        public void SortByName()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "The Terminator", Year = 1984 },
                new Movie { Title = "A Clockwork Orange", Year = 1971 },
                new Movie { Title = "Inception", Year = 2010 }
            };

            List<Movie> sortedMovies = Sorting.SortByName(new List<Movie>(movies));

            Assert.Equal("A Clockwork Orange", sortedMovies[0].Title);
            Assert.Equal("Inception", sortedMovies[1].Title);
            Assert.Equal("The Terminator", sortedMovies[2].Title);
        }

        [Fact]
        public void SortByYear()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "The Terminator", Year = 1984 },
                new Movie { Title = "A Clockwork Orange", Year = 1971 },
                new Movie { Title = "Inception", Year = 2010 }
            };

            List<Movie> sortedMovies = Sorting.SortByYear(new List<Movie>(movies));

            Assert.Equal(2010, sortedMovies[0].Year);
            Assert.Equal(1984, sortedMovies[1].Year);
            Assert.Equal(1971, sortedMovies[2].Year);
        }

        [Fact]
        public void CompareTitlesReturnNegative()
        {
            int result = Sorting.CompareTitles("A Clockwork Orange", "Inception");

            Assert.True(result < 0);
        }

        [Fact]
        public void CompareTitles_ShouldReturnPositive()
        {
            int result = Sorting.CompareTitles("Inception", "A Clockwork Orange");

            Assert.True(result > 0);
        }

        [Fact]
        public void WhenTitlesAreEqual()
        {
            int result = Sorting.CompareTitles("Inception", "Inception");

            Assert.Equal(0, result);
        }


    }
}
