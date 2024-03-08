using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check each argument
            foreach (string s in args)
            {
                //Condition if > 3 and < 6
                if (s.Length > 3 && s.Length < 6)
                {
                    Console.WriteLine(s);
                } 
                //Condition if > 6
                else if (s.Length > 6)
                {
                    break;
                }
                // Condition any other number
                else
                {
                    continue;
                }
            }
        }
    }
}
