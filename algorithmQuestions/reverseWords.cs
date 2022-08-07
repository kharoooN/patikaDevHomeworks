using System.Collections.Generic;
using System;
using System.Linq;

//Program kullanıcının belirttiği sayı kadar kelime girmesini, daha sonra bu kelimeleri tersten sıralamayı yapıyor.

public class Program
{
    static void Main(string[] args)
    {
        ReverseWords();
    }

    public static void ReverseWords()
    {
        Console.Write("Kaç adet kelime girilecek : ");
        string wordCount = (Console.ReadLine());


        List<string> words = new List<string>();
        for (int i = 0; i < int.Parse(wordCount); i++)
        {
            Console.Write("Kelime giriniz : ");
            String line = Console.ReadLine();
            
            words.Add(line);

        }
        words.Reverse();

        foreach (var item in words)
        {
            Console.Write(item + " ");
        }
    }
}
