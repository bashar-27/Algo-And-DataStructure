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

            foreach (char c in chars)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    // Push the element in the stack
                    s1.Push(c);
                    continue;
                }

                            if (s1.Count == 0)
                    return false;

                char check;
                switch (c)
                {
                    case ')':
                        check = (char)s1.Pop();
                        if (check == '{' || check == '[')
                            return false;
                        break;

                    case '}':
                        check = (char)s1.Pop();
                        if (check == '(' || check == '[')
                            return false;
                        break;

                    case ']':
                        check = (char)s1.Pop();
                        if (check == '(' || check == '{')
                            return false;
                        break;
                }
            }

           
            return s1.Count == 0;
        }
    }
            
      } 
   
        