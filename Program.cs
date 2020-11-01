using System;

namespace HangmanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instacja klasy do losowania słowa ze słownika z pliku
            FileReaderClass fileReader = new FileReaderClass();
            string word = fileReader.RandomWordFromDictionary().ToLower();
            UserInputOutput play = new UserInputOutput(word);
            // bool playing = true;
            play.MenuIntro();

            // pętla może być przerwana w przypadku zwycięstwa i porażki. 
            while (play.Lives > 0)
            {
                play.NewRound();
                play.CheckLetter(Console.ReadLine().Substring(0, 1).ToLower());
                if (play.Wincheck())
                {
                    break;
                }
            }
                
            if (play.Win)
            {
                Console.WriteLine("Wygrałeś");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Spróbuj jeszcze raz");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
