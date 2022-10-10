using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCode
{
    class Program
    {
        static void translateToMorse()
        {
            Dictionary<char, string> morse = new Dictionary<char, string>();
            morse.Add('a', ".-");
            morse.Add('b', "-...");
            morse.Add('c', "-.-.");
            morse.Add('d', "-..");
            morse.Add('e', ".");
            morse.Add('f', "..-.");
            morse.Add('g', "--.");
            morse.Add('h', "....");
            morse.Add('i', "..");
            morse.Add('j', ".---");
            morse.Add('k', "-.-");
            morse.Add('l', ".-..");
            morse.Add('m', "--");
            morse.Add('n', "-.");
            morse.Add('o', "---");
            morse.Add('p', ".--.");
            morse.Add('q', "--.-");
            morse.Add('r', ".-.");
            morse.Add('s', "...");
            morse.Add('t', "-");
            morse.Add('u', "..-");
            morse.Add('v', "...-");
            morse.Add('w', ".--");
            morse.Add('x', "-..-");
            morse.Add('y', "-.--");
            morse.Add('z', "--..");

            string cont; //Aux variable to continue using the translator
            string input;
            
            Console.Clear();
            do
            {
                Console.WriteLine("Enter the text to translate to morse code: ");
                input = Console.ReadLine();
                input = input.ToLower();
                for (int i = 0; i < input.Length; i++)
                {
                    if (morse.ContainsKey(input[i]))
                    {
                        Console.Write(morse[input[i]] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\nDo you want to translate another text? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine("");
            } while (cont == "y");

            Console.WriteLine("\t\n--Press any key to exit--");
            Console.ReadKey();

        }
        
        static void translateToText() 
        {
            Dictionary<string, char> text = new Dictionary<string, char>();
            text.Add(".-", 'a');
            text.Add("-...", 'b');
            text.Add("-.-.", 'c');
            text.Add("-..", 'd');
            text.Add(".", 'e');
            text.Add("..-.", 'f');
            text.Add("--.", 'g');
            text.Add("....", 'h');
            text.Add("..", 'i');
            text.Add(".---", 'j');
            text.Add("-.-", 'k');
            text.Add(".-..", 'l');
            text.Add("--", 'm');
            text.Add("-.", 'n');
            text.Add("---", 'o');
            text.Add(".--.", 'p');
            text.Add("--.-", 'q');
            text.Add(".-.", 'r');
            text.Add("...", 's');
            text.Add("-", 't');
            text.Add("..-", 'u');
            text.Add("...-", 'v');
            text.Add(".--", 'w');
            text.Add("-..-", 'x');
            text.Add("-.--", 'y');
            text.Add("--..", 'z');

            string cont; //Aux variable to continue using the translator
            string input;
            
            Console.Clear();
            do
            {
                Console.WriteLine("Enter the morse code to translate to text: ");
                input = Console.ReadLine();
                string[] words = input.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (text.ContainsKey(words[i]))
                    {
                        Console.Write(text[words[i]]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\nDo you want to translate another text? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine("");
            } while (cont == "y");

            Console.WriteLine("\t\n--Press any key to exit--");
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            int auxMenu;

            Console.WriteLine("\tWelcome to the Morse Code Translator!" +
                               "\n\tPlease select from the following options:");
            Console.WriteLine("1. Translate to morse code");
            Console.WriteLine("2. Translate to text");
            Console.WriteLine("3. Exit");
            Console.Write("Option selected: ");
            auxMenu = Convert.ToInt32(Console.ReadLine());

            switch (auxMenu)
            {
                case 1:
                    translateToMorse();
                    break;
                case 2:
                    translateToText();
                    break;
                case 3:
                    Console.WriteLine("\t\n--Press any key to exit--");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }


        }
    }
}