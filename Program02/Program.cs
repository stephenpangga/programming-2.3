using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            //question B
            List<string> words = new List<string>();
            words = ListOfWords();
            //choosing the word.
            SelectWord(words);

            HangmanGame hangman = new HangmanGame();

            //hangman.Init("backdoor");
            hangman.Init(SelectWord(words));
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord);

            PlayHangman(hangman);

        }

        List<string> ListOfWords()
        {
            List<string> Lwords = new List<string>();
            Lwords.Add("Regina");
            Lwords.Add("Stephen");
            Lwords.Add("Sisa");
            Lwords.Add("Eleanor");
            Lwords.Add("Lola");
            Lwords.Add("Amy");
            Lwords.Add("Bebe");
            Lwords.Add("Roo");
            return Lwords;
        }

        string SelectWord(List<string> words)
        {
            //randomizer
            Random rnd = new Random();
            int value = rnd.Next(0, words.Count);
            string randomWord = words.ElementAt(value);
            return randomWord;
        }

        bool PlayHangman(HangmanGame hangman)
        {
            //Letter Storage
            List<char> enteredLetters = new List<char>();
            DisplayWord(hangman.guessedWord);
            DisplayLetters(enteredLetters);

            ReadLetter(enteredLetters);
            //word guessed?
            return true;
        }

        void DisplayWord(string word)
        {
            string secret = "";
            foreach(char c in word)
            {
                secret = secret + c + " ";
            }

            Console.WriteLine($"The Secret word is: {secret}");
        }

        void DisplayLetters(List<char> letters)
        {
            foreach(char c in letters)
            {
                Console.Write(c + " ");
            }
        }

        char ReadLetter(List<char> blacklistLetters)
        {
            Console.Write("Enter a letter: ");
            //string letter = Console.ReadLine();
            char letter = char.Parse(Console.ReadLine());
            while (blacklistLetters.Contains(letter))
            {

                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());

            }
            blacklistLetters.Add(letter);
            return letter;
        }

       
    }
}
