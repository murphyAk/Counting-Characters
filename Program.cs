using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
/*            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();*/
            

            char[] charArray = word.ToCharArray();

            for(int i=0; i<charArray.Length; i++)
            {
                if (!letterCount.TryGetValue(charArray[i], out int counter))
                {
                    letterCount.Add(charArray[i], 1);
                }
                else
                {
                    letterCount[charArray[i]] = counter + 1; ;
                }
            }


            foreach (KeyValuePair<char, int> number in letterCount)
            {
                Console.WriteLine($"{number.Key}: {number.Value}");
            }
        }
    }
}
