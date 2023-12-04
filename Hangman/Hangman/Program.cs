using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array=lista di parole da prendere
            string[] words = { "csharp", "visualstudio", "language", "array", "parsing", "constant" };

            //verificare l'input del player sia tra 'a' e 'z'. 
            var validCharacters = new Regex("^[a-z]$");

            //Lenghth legge la lunghezza egli array si usa -1 perchè inizia a leggere da 1 invece l'array legge da 0. Prende un numero casuale
            int myRandomNumber = new Random().Next(0, words.Length - 1);

            //word è la stringa da usare e ciao che c'è tra le parentesi qaudre è il numero tirato a sorte da prendere nell'array. Prende una poarola casual edall'array
            string wordToGuess = words[myRandomNumber];

            //Numero di vite
            int lives = 3;

            // Lista di lettere provate dal player. List è come un array ma variabile ovvero uyn alist adi oggetti variabili
            List<string> list = new();

            //Fino a quando il player ha vite il gioco continua. While continua a girare fino a quando la condizione non è vera
            while (lives != 0)
            {

            }
        }
    }
}
