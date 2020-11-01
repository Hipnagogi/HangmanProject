using System;

namespace HangmanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instacja klasy do losowania słowa ze słownika z pliku
            FileReaderClass fileReader = new FileReaderClass();
            string word = fileReader.RandomWordFromDictionary();
            bool playing = true;
            bool win=false;

            // pętla może być przerwana w przypadku zwycięstwa i porażki. 
            while (playing)
            {
                Console.WriteLine("Podaj literę");
                string userLetter =  Console.ReadLine().Substring(0,1);
                if (word.Contains(userLetter))
                {

                }
                else
                {

                }
            }

            if (win)
            {
                Console.WriteLine("Gratulacje wygrałeś");
            }
            else
            {
                Console.WriteLine("Spróbuj jeszcze raz");
            }


        }
    }
}
