using System;
using System.Collections.Generic;

namespace CapitalLetter{
    class Program{
        public static void Main(){
            List<char> capitalLetters = new List<char>();

            Console.WriteLine("Enter a string");

            string userInput = Convert.ToString(Console.ReadLine());

            if(userInput.Length != 0){
                char[] charArray = userInput.ToCharArray();

                foreach(char l in charArray){
                    if(Char.IsUpper(l)){
                        capitalLetters.Add(l);
                    }
                }
            }

            foreach(char item in capitalLetters){
                Console.WriteLine($"Index: {userInput.IndexOf(item)} \t Character: {item}");
            }

            Console.Read();
        }
    }
}