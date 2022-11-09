using System;

namespace MaskedString{
    class Program{
        public static void Main(){
            Console.WriteLine("Enter a word");

            string word = Convert.ToString(Console.ReadLine().Trim());


            string minusTheLastFourLetters = word.Substring(0, word.Length - 4);
            string lastFourLetters = word.Substring(word.Length - 4);


            string hashString = "";
            

            foreach(char letter in minusTheLastFourLetters){
                hashString += "#";
            }

            string maskedString = hashString + lastFourLetters;

            Console.WriteLine(maskedString);
        }
    }
}