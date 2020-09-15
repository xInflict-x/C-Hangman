using System;

class MainClass {
  public static void Main (string[] args) {
    hangman();
  }

  static void hangman(){
            int wrongGuesses = 0;
            Console.WriteLine("Player 1: Enter a word.");
            string wordToGuess = Console.ReadLine();
            char[] guess = new char[wordToGuess.Length];
            for (int i = 0; i < wordToGuess.Length; i++){
                guess[i] = '-';
            }
            while (true){
                Console.WriteLine(guess);
                string finalWord = new string(guess);
                if (finalWord == wordToGuess){
                    Console.WriteLine("You win!");
                    Console.WriteLine($"You got {wrongGuesses} letter(s) wrong");
                    break;
                }
                Console.WriteLine("Player 2: Guess a letter.");
                char playerguess = Char.Parse(Console.ReadLine());
                for(int j = 0; j < wordToGuess.Length; j++){
                    if (wordToGuess[j] == playerguess){
                        guess[j] = playerguess;
                    }
                }
                if (wordToGuess.Contains(playerguess)){
                    Console.WriteLine("Correct!");
                    }
                else {
                    Console.WriteLine("Incorrect!");
                    wrongGuesses ++;
                    }
            }
        }
}
