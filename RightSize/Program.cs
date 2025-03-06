using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string Text ="";
            Text = Console.ReadLine();

            foreach (var word in Text)
            {
                if(word == ' ')
                {
                    Console.WriteLine(word);
                }
                else
                {
                    Console.Write(word);
                }
                
            }
        }
    }
}
