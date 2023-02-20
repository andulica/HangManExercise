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


            while (secretWord.Contains('_') && counter < MAX_CHANCES)
            {

                Console.WriteLine("Please guess a letter from the word: ");
                char playerGuess = Console.ReadKey().KeyChar;
                Console.WriteLine();


                if (pickedWord.Contains(playerGuess))
                {
                    for (int i = 0; i < pickedWord.Length; i++)
                    {
                        if (playerGuess == pickedWord[i])
                        {
                            secretWord[i] = playerGuess;
                        }
                        Console.Write(" " + secretWord[i] + " ");
                    }
                }
                else
                {
                    counter++;
                    Console.WriteLine("You have left " + (MAX_CHANCES - counter) + " chances.");
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