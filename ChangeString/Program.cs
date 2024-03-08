using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get both inputs from the user
            char substitute;
            Console.Write("Insert a phrase: ");
            string phrase = Console.ReadLine();
            Console.Write("Which character to substitute: ");
            substitute = char.Parse(Console.ReadLine());
            string output ="";

            //Check if the character is present in the string
            foreach(char character in phrase)
            {
                if(character == substitute)
                {
                    output += "X";
                }
                else
                {
                    output += character;
                }
            }
            //Output result
            Console.WriteLine(output);
        }
    }
}
