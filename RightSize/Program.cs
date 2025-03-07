using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {


            foreach (var word in args)
            {
                if(word.Length<=3)
                {
                    
                }
                else if(word.Length>=8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else
                {
                    Console.WriteLine(word);
                }
                
            }
        }
    }
}
