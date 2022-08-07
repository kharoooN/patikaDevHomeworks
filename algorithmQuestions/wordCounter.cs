using System;

// Program, kullanıcının girdiği cümledeki kelime ve harf sayılarını döndürüyor.

public class Program
{
    static void Main(string[] args)
    {
        WordCounter();
    }

    static void WordCounter()
    {
        Console.WriteLine("Bir cümle yazınız : ");
        string sentence = Console.ReadLine();

        int space = 0; 
        int word = 1;
        int character = 0;
        
        foreach(char c in sentence){
            if(c == ' ')
            {
                space++;
            }
        }

        character = (sentence.Length) - space;
        word = word+space;

        Console.Write($"Harf sayisi {character}\nKelime sayisi {word}");
    }
}
