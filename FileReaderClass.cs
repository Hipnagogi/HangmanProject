using System;
using System.Collections.Generic;
using System.IO;

public class FileReaderClass	
{
	List<string> dict = new List<string>();
	public FileReaderClass()
	{
		var file = new FileStream(@".\Wordlist.txt", FileMode.Open);
		var reader =new StreamReader(file);
		while (!reader.EndOfStream) {
			dict.Add(reader.ReadLine());
		}
		reader.Close();
		file.Close();
	}
	public string RandomWordFromDictionary() {
		int temp =  dict.Count -1;
		Random rnd = new Random();
        int v =  rnd.Next(0,temp);
		return dict[v];
	}
}
