using System.Collections.Generic;
using System;

// Program kullanıcıdan sayı isteyip, o sayı kadar sayı girmesini ve girilen sayılardan, tam bölünen ya da eşit olanları gösterecektir.

public class Program
{
    static void Main(string[] args)
    {
        DivisibleNumbers();
    }

    public static void DivisibleNumbers()
    {
        Console.Write("Kaç adet sayı girilecek : ");
        string numbers = Console.ReadLine();
        Console.Write("Bir sayı giriniz : ");
        int secondNumber = int.Parse(Console.ReadLine());

        List<int> nums = new List<int>();
        for (int i = 0; i < int.Parse(numbers); i++)
        {
            Console.Write("Sayi Giriniz : ");
            int line = int.Parse(Console.ReadLine());
            
            if (line % secondNumber == 0 || line == secondNumber)
            {
                nums.Add(line);
            }

        }

        foreach (var item in nums)
        {
            Console.Write(item + " ");
        }
    }
}
