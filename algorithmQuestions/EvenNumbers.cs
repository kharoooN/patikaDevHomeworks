using System.Collections.Generic;
using System;

//Kullanıcıdan pozitif bir sayı alıp, o sayı adedi kadar sayı girmesini isteyip, pozitif sayıları döndürecektir.

public class Program
{
    static void Main(string[] args)
    {
        EvenNumbers();
    }

    public static void EvenNumbers()
        {
            Console.Write("Kaç adet sayı girilecek : ");
            string numbers = Console.ReadLine();
            List<int> nums = new List<int>();
            for (int i = 0; i < int.Parse(numbers); i++)
            {
                Console.Write("Sayi Giriniz : ");
                int line = int.Parse(Console.ReadLine());
                if (line % 2 == 0) nums.Add(line);
            }

            foreach(var j in nums)
            {
                Console.WriteLine(j);
            }
        }
}
