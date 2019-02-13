using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TypeGameOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We begin the typing game");

            List<char> alphabet = new List<char>();
            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('d');
            alphabet.Add('e');
            alphabet.Add('f');
            alphabet.Add('g');
            alphabet.Add('h');
            alphabet.Add('i');
            alphabet.Add('j');
            alphabet.Add('k');
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o');
            alphabet.Add('p');
            alphabet.Add('q');
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u');
            alphabet.Add('v');
            alphabet.Add('w');
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');
            while (true)
            {
                char input = (Console.ReadKey().KeyChar);
                
                Console.WriteLine(input);

                if (alphabet[0] == input)
                {
                    Console.WriteLine(alphabet.Count);
                    alphabet.RemoveAt(0);
                    
                }
                
                
                if (alphabet.Count <= 0)
                {
                    Console.WriteLine("Alphabet done!");
                    break;
                }
                Console.WriteLine(alphabet.Count);
            }

            ////User input
            //char[] arr = new char[1];
            //Console.WriteLine("Please enter a letter only: ");
            //string s = "abcdefghijklmnopqrstuvwxyz";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string sChar = Console.ReadLine().ToLower();
            //    if (s.Contains(sChar) && sChar.Length == 1)
            //    {
            //        arr[i] = Convert.ToChar(sChar);
            //        i++;
                      
            //        Console.WriteLine("Congratulations you entered a letter!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input, start over.");
            //        continue;
            //    }
            //}
            ////display
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("You have entered the following inputs: ");
            //    Console.WriteLine(arr[i]);
            //}
        }
    }
}
