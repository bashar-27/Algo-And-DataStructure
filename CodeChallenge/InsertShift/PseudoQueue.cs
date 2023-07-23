using System.Collections.Generic;
using System;

namespace InsertShift
{
    public class PseudoQueue
    {
        private Stack<int> inputStack;
        private Stack<int> outputStack;

        public PseudoQueue()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        public void Enqueue(int value)
        {
            while (outputStack.Count > 0)
            {
                inputStack.Push(outputStack.Pop());
            }

            inputStack.Push(value);
        }

        public int Dequeue()
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }

            if (outputStack.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return outputStack.Pop();
        }
    }
    
}