using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System;

namespace HangManExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //            Hangman is a game where a word is secretly chosen and the player guesses letters to fill in the word.
            //Each correct guess fills in that letter in the word. Guess too many wrong letters and the player loses.
            //Tips: It is all a matter of taking the letter the player guesses and looping through the word comparing it to each letter in the word character by character.
            //If the letters match, you show that letter to the player. If you reach the end of the word and no letters have been matched, it is a wrong guess.
            //Remember that strings are often treated as an array of characters.Most languages have a function to fetch a single letter from a string.
            //Keep track of how many wrong guesses the player has done and use this number to determine if the game has been won or lost.
            //Added Difficulty: Increase the length of the words and choose more complex unknown words to have the player guess.


            //Create a list of words with which the player will play and tell him to choose a number that will represent the position of that word in that array
            //once the word had been chose, create the layoit fro the hangman game will all the lines 
            //ask the user to enter a letter 
            //compare the letter with the word using a for loop
            //if the letter is inside that word , put that letter where it needs to be and then ask the user again 

            string[] wordsToChoose = { "abruptly", "absurd", "abyss", "affix", "askew", "avenue", "awkward", "axiom" };
            const int MAX_CHANCES = 10;
            int counter = 0;

            Console.WriteLine("Please enter a number from 0 to 7: ");
            int playerPickNumber = Convert.ToInt16(Console.ReadLine());
            string playerPickWord = wordsToChoose[playerPickNumber];

            Console.WriteLine("This word has been chosen: " + playerPickWord);

            char[] chars = new char[playerPickWord.Length];



            for (int i = 0; i < playerPickWord.Length; i++)
            {
                chars[i] = '_';
            }

            foreach (char underscore in chars)
            {
                Console.Write(" " + underscore + " ");
            }


            while (chars.Contains('_') && counter < MAX_CHANCES) 
            {

                Console.WriteLine("Please guess a letter from the word: ");
                char playerGuess = Convert.ToChar(Console.ReadLine());


                if (playerPickWord.Contains(playerGuess))
                    {
                    for (int i = 0; i < playerPickWord.Length; i++)
                    {
                        if (playerGuess == playerPickWord[i])
                        {
                            chars[i] = playerGuess;
                        }
                        Console.Write(" " + chars[i] + " ");
                    }
                }
                else
                {
                    counter++;
                    Console.WriteLine("You have left " + (MAX_CHANCES - counter));
                }
            }

            Console.WriteLine("Congratulations , you winned!");
        }      
    }
}