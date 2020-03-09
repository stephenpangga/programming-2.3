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
    }
}
