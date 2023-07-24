using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class validateBrackets
    {
        public static bool IsvalidateBrackets(string bracket)
        {
            char[] chars = bracket.ToCharArray();
            Stack s1 = new Stack();
            Stack<char> myStack = new Stack<char>();

            foreach (char c in chars)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    // Push the element in the stack
                    myStack.Push(c);
                    continue;
                }

                          if(myStack.Count==null)
                    return false;

                char check;
                switch (c)
                {
                    case ')':
                        check = myStack.Pop();
                        if (check == '{' || check == '[')
                            return false;
                        break;

                    case '}':
                        check = (char)myStack.Pop();
                        if (check == '(' || check == '[')
                            return false;
                        break;

                    case ']':
                        check = (char)myStack.Pop();
                        if (check == '(' || check == '{')
                            return false;
                        break;
                }
            }

           
            return myStack.Count == 0;
        }
    }
            
      } 
   
        