using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] Words = new string[100];
            string Text="";
            int contador = 0;
            Text = Console.ReadLine();

            foreach (var word in Text)
            {
                if(word == ' ')
                {
                    contador++;
                }
                else
                {
                    Words[contador]+= word;
                }
                
            }
            foreach (var item in Words)
            {
                if(item.Length<=3)
                {
                    
                }
                else if(item.Length>=8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
