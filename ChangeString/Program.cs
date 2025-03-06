using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string text = "";
            char character;
            Console.Write("String: ");
            text = Console.ReadLine();
            Console.Write("Caráter: ");
            character = Convert.ToChar(Console.ReadLine());

            foreach (var charater in text)
            {
                if(character == charater)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(charater);
                }
            }

            
        }
    }
}
