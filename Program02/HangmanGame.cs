using System;
using System.Collections.Generic;
using System.Text;

namespace Program02
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        public void Init(string secretWord)
        {
            foreach (char letter in secretWord)
            {
                this.secretWord = secretWord;//just to show the word according to jurek.
                guessedWord += ".";
            }
        }
        public bool GuessLetter(char letter)
        {
            bool match = false;
            StringBuilder newguessletter = new StringBuilder(guessedWord);
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    newguessletter[i] = letter;
                    match = true;
                }
            }
            guessedWord = newguessletter.ToString();
            return match;
        }
    }
}
