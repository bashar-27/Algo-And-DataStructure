using System;

namespace InsertShift
{
    public class Program
    {
        

        static void Main(string[] args)
        {


            string bracket = "{}";
            Console.WriteLine(validateBrackets.IsvalidateBrackets(bracket));
            string bracket2 = "{[}";
            Console.WriteLine(validateBrackets.IsvalidateBrackets(bracket2));
            string bracket3 = "(";
            Console.WriteLine(validateBrackets.IsvalidateBrackets(bracket3));
            string bracket4 = "{()[{}]}";
            Console.WriteLine(validateBrackets.IsvalidateBrackets(bracket4));

        }



    }
}