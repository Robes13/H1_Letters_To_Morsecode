using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsecode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to write what they want translated to morsecode
            Console.WriteLine("Hello, please type in the message you want translated to morsecode.");
            /* Taking input and putting it in a char array, and also putting everything ToLower so 
             * the letters will match even if they're upper case
             */
            string letters_pre = Console.ReadLine().ToLower();
            // Creating an empty string, so we can add the desired morsecode for each letter
            string letters_post = "";
            /* Creating a foreach loop, every char in our char[] array will be replaced by c, 
             * and will run as long as there is a char left in the array. 
             * then the c is put in a switch, and the switch looks for a match,
             * if it doesnt find a match it will take the default and put a "?" ( in morsecode ofc). 
             */
            foreach (char c in letters_pre)
                switch(c)
                {
                    case 'a':
                        letters_post = letters_post + " - . ";
                        break;
                    case 'b':
                        letters_post = letters_post + " - . . . ";
                        break;
                    case'c':
                        letters_post = letters_post + " — · — · ";
                        break;
                    case 'd':
                        letters_post = letters_post + " — · · ";
                        break;
                    case 'e':
                        letters_post = letters_post + " . ";
                        break;
                    case 'f':
                        letters_post = letters_post + " . . - . ";
                        break;
                    case 'g':
                        letters_post = letters_post + " - - . ";
                        break;
                    case 'h':
                        letters_post = letters_post + " . . . . ";
                        break;
                    case 'i':
                        letters_post = letters_post + " . . ";
                        break;
                    case 'j':
                        letters_post = letters_post + " . - - - ";
                        break;
                    case 'k':
                        letters_post = letters_post + " - . - ";
                        break;
                    case 'l':
                        letters_post = letters_post + " . - . . ";
                        break;
                    case 'n':
                        letters_post = letters_post + " - .";
                        break;
                    case 'm':
                        letters_post = letters_post + " - - ";
                        break;
                    case 'o':
                        letters_post = letters_post + " - - - ";
                        break;
                    case 'p':
                        letters_post = letters_post + " . - - . ";
                        break;
                    case 'q':
                        letters_post = letters_post + " - - . - ";
                        break;
                    case 'r':
                        letters_post = letters_post + " . - . ";
                        break;
                    case 's':
                        letters_post = letters_post + " . . . ";
                        break;
                    case 't':
                        letters_post = letters_post + " - ";
                        break;
                    case 'u':
                        letters_post = letters_post + " . . - ";
                        break;
                    case 'v':
                        letters_post = letters_post + " . . . - ";
                        break;
                    case 'w':
                        letters_post = letters_post + " . - - ";
                        break;
                    case 'x':
                        letters_post = letters_post + " - . . - ";
                        break; 
                    case 'y':
                        letters_post = letters_post + " - . - - ";
                        break;
                    case 'z':
                        letters_post = letters_post + " - - . . ";
                        break;
                    case 'æ':
                        letters_post = letters_post + " . - . - ";
                        break;
                    case 'ä':
                        letters_post = letters_post + " . - . - ";
                        break;
                    case 'ø':
                        letters_post = letters_post + " - - - . ";
                        break;
                    case 'ö':
                        letters_post = letters_post + " - - - . ";
                        break;
                    case 'ó':
                        letters_post = letters_post + " - - - . ";
                        break;
                        //
                        //
                        //
                        //
                    case '1':
                        letters_post = letters_post + " . - - - - ";
                        break;
                    case '2':
                        letters_post = letters_post + " . . - - -";
                        break;
                    case '3':
                        letters_post = letters_post + " . . . - -";
                        break;
                    case '4':
                        letters_post = letters_post + " . . . . - ";
                        break;
                    case '5':
                        letters_post = letters_post + " . . . . . ";
                        break;
                    case '6':
                        letters_post = letters_post + " - . . . . ";
                        break;
                    case '7':
                        letters_post = letters_post + " - - . . . ";
                        break;
                    case '8':
                        letters_post = letters_post + " - - - . . ";
                        break;
                    case '9':
                        letters_post = letters_post + " - - - - . ";
                        break;
                    case '0':
                        letters_post = letters_post + " - - - - - ";
                        break;
                    case '.':
                        letters_post = letters_post + " · — · — · — ";
                        break;
                    case ',':
                        letters_post = letters_post + " — — · · — — ";
                        break;
                    case ':':
                        letters_post = letters_post + " — — — · · · ";
                        break;
                    case '?':
                        letters_post = letters_post + " · · — — · · ";
                        break;
                    case '\'':
                        letters_post = letters_post + " · — — — — · ";
                        break;
                    case '-':
                        letters_post = letters_post + " — · · · · — ";
                        break;
                    case ' ':
                        letters_post = letters_post + " / ";
                        break;
                    case '/':
                        letters_post = letters_post + " — · · — ·  ";
                        break;
                    case '(':
                        letters_post = letters_post + " — · — — · ";
                        break;
                    case ')':
                        letters_post = letters_post + " — · — — · —  ";
                        break;
                    case '\"':
                        letters_post = letters_post + " · — · · — ·  ";
                        break;
                    case '\n':
                        letters_post = letters_post + "  — · — ";
                        break;
                    case '@':
                        letters_post = letters_post + " . - - . - . ";
                        break;
                    case '*':
                        letters_post = letters_post + " - . . - ";
                        break;
                    default:
                        letters_post = letters_post + " · · — — · · ";
                        break;
                }
            // Getting ready to write our morsecode
            Console.WriteLine("This is your text in morsecode: \n");
            // Writing the morsecode.
            Console.Write(letters_post);
            // Readline so we can observe the morsecode.
            Console.ReadLine();
        }
    }
}
