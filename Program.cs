using System.Collections;

namespace HangManExercise
{
    internal class Program
    {
        const int MAX_CHANCES = 10;

        static void Main(string[] args)
        {

            string[] wordsToChoose = { "abruptly", "absurd", "abyss", "affix", "askew", "avenue", "awkward", "axiom" };
            int counter = 0;
            Random randNumber = new Random();
            int randNumberChosen = randNumber.Next(0, wordsToChoose.Length);
          
            string pickedWord = wordsToChoose[randNumberChosen];

            char[] secretWord = new char[pickedWord.Length];
            
            for (int i = 0; i < pickedWord.Length; i++)
            {
                secretWord[i] = '_';
            }

            foreach (char underscore in secretWord)
            {
                Console.Write(" " + underscore + " ");
            }

            var guessedChars = new ArrayList();

            while (secretWord.Contains('_') && counter < MAX_CHANCES)
            {

                Console.WriteLine("Please guess a letter from the word: ");
                char playerGuess = Console.ReadKey().KeyChar;
                
                Console.WriteLine();

                // Checks if the character chose by the player is in the secret word by looping through all the array and if it is
                // it will be added at the right location in the array of secretWord
                if (pickedWord.Contains(playerGuess) && !guessedChars.Contains(playerGuess))
                {
                    for (int i = 0; i < pickedWord.Length; i++)
                    {
                        if (playerGuess == pickedWord[i])
                        {
                            secretWord[i] = playerGuess;
                            guessedChars.Add(playerGuess);
                        }
                        Console.Write(" " + secretWord[i] + " ");
                                             
                    }
                    
                }

                else if (guessedChars.Contains(playerGuess))
                {
                    Console.WriteLine("You already guessed this letter!");
                }
                               
                else
                {
                    counter++;
                    Console.WriteLine("Wrong answer! You have left " + (MAX_CHANCES - counter) + " chances.");
                }
            }

            if (counter >= MAX_CHANCES)
            {
                Console.WriteLine("You lost!");
            }
            else
            {
                Console.WriteLine("Congratulations , you win!");
            }
        }
    }
}