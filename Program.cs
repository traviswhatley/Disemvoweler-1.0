using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program is going to be awesome
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the funcions and I make the calls");
            Console.ReadKey();
        }

        static void Disemvoweler(string input)
        {
            //setting input to lower case
            input = input.ToLower();
            int i = 0;
            //letter is index of input
            char letter = input[i];
            //consonantResult is "empty"
            string consonantResult = "";
            //vowelResult is "empty"
            string vowelResult = "";
            for (i = 0; i < input.Length; i++)
            {
                letter = input[i];
                //if letter is a consonant add to consonantResult
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' && letter != ' ' && letter != '.' && letter != '?'
                    && letter != '!' && letter != '\''  && letter != ',')
                {
                    consonantResult += letter;
                }
                //if letter is a vowel add to vowelResult
                else if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' && letter != ' ' && letter != '.' && letter != '?'
                    && letter != '!' && letter != '\''  && letter != ',')
                {
                    vowelResult += letter;
                }
            }
            //print original input
            Console.WriteLine("Original: " + input);
            //print disemvoweled input
            Console.WriteLine("Disemvoweled: " + consonantResult);
            //print vowels of input
            Console.WriteLine("Vowels: " + vowelResult);
            Console.WriteLine();
        }
    }
}
