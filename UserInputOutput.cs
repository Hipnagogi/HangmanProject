using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

public class UserInputOutput
{
	//Użycie klasy string builder.
	private StringBuilder str = new StringBuilder();

	//Propertisy odpowiedzialne za liczbę żyć i wyświetlanie stanu gry.
	public int Lives { get; set; }
	//Propertis przechowujący długość wyrazu
	public int WordLength { get; set; }
	public string Word { get; set; }
	private string displayWord="";
	public bool Win { get; set; }
	// Konstruktor przyjmujący słowo w parametrze
	public UserInputOutput(string word)
	{
		Lives = 17;
		WordLength = word.Length;
		Word = word;
		Win = false;
		for (int i = 0; i < WordLength; i++) { 
			displayWord +="-";
        }
		str.Append(displayWord);
		
	}

	// Intro gry wyświetlane na początku.
	public void MenuIntro()
    {
		Console.WriteLine("=======================================================================");
		Console.WriteLine();
		Console.WriteLine("0   0       0     00    0    0000     00     00      00     00    0");
		Console.WriteLine("0   0      0 0    0 0   0   0         0 0   0 0     0  0    0 0   0");
		Console.WriteLine("00000     0   0   0  0  0  0  000000  0  0 0  0    0    0   0  0  0");
		Console.WriteLine("0   0   00000000  0   0 0   0   0     0   0   0   00000000  0   0 0");
		Console.WriteLine("0   0   0      0  0    00    000      0       0  0       0  0    00");
		Console.WriteLine();
		Console.WriteLine("======================================================================");
    }
	public void InsertLetter()
    {
		Console.WriteLine("Podaj literę");
    }

	public void NewRound()
    {
		Console.WriteLine("===================================================");
		Console.WriteLine("===================================================");
		Console.WriteLine();
		Console.Write("HASŁO: ");
		Console.WriteLine(displayWord);
		InsertLetter();
    }
	private void DisplayWord(List<int> list, string c)
    {
		foreach(int i in list)
        {
			str[i] = Convert.ToChar(c);
        }
		displayWord = str.ToString();
		//return displayWord;
    }

	public void CheckLetter(string s)
    {
		if (Word.Contains(s))
		{
			
			List <int> letters = new List<int>();
			int i = 0;
			foreach (char c in Word )
            {
				if (Convert.ToChar(s)==c)
                {
					letters.Add(i);
				}
				i++;
            }
			DisplayWord(letters, s);
   
		}
		else
		{
			Lives--;
		}
		Console.Clear();
		Console.WriteLine(displayWord);
		HangmanPrint();
	}
	public void HangmanPrint()
    {
        switch (Lives)
        {	
			case 16:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	    ");
				Console.WriteLine(@"	    ");
				Console.WriteLine(@"	    ");
				Console.WriteLine(@"	    ");
				Console.WriteLine(@"		");
				Console.WriteLine(@"	|   ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 15:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 14:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	   ");
				Console.WriteLine(@"	   ");
				Console.WriteLine(@"	   ");
				Console.WriteLine(@"	|  ");
				Console.WriteLine(@"	|  ");
				Console.WriteLine(@"	|  ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 13:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 12:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	  ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 11:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	- ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine(@"	| ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 10:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	--  ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 9:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	---  ");
				Console.WriteLine(@"	|    ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;
			
			case 8:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	----  ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|    ");
				Console.WriteLine(@"	|  	 ");
				Console.WriteLine(@"	|    ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;
			
			case 7:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 6:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|     ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;
			
			case 5:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|   ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 4:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|   | ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;
			
			case 3:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|  /| ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;
			
			case 2:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|  /|\ ");
				Console.WriteLine(@"	|  	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 1:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|  /|\ ");
				Console.WriteLine(@"	|  / 	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				break;

			case 0:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	-----  ");
				Console.WriteLine(@"	|   |  ");
				Console.WriteLine(@"	|   o  ");
				Console.WriteLine(@"	|  /|\ ");
				Console.WriteLine(@"	|  / \	");
				Console.WriteLine(@"	|       ");
				Console.WriteLine();
				Console.WriteLine("--------------------");
				Console.WriteLine(">>>---YOU-LOST---<<<");
				Console.WriteLine("--------------------");
				break;
			
			default:
				Console.WriteLine("--------------------");
				Console.WriteLine($"------Left-{Lives}------");
				Console.WriteLine("--------------------");
				Console.WriteLine();
				Console.WriteLine(@"	 ");
				Console.WriteLine(@"	 ");
				Console.WriteLine(@"	 ");
				Console.WriteLine(@"	 ");
				Console.WriteLine(@"	 ");
				Console.WriteLine(@"	 ");
				Console.WriteLine();
				Console.WriteLine("--------------------");

				break;

		}
	}
	public bool Wincheck()
    {
		if (!displayWord.Contains('-'))
        {
			Win = true;
			return true;
        }
		return false;
    }

	
	


}
