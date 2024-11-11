﻿using System;

public class Program
{
    static int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the number you want to search for: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(search(number));

    }

    public static String search(int number)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (Numbers[i] == number)
            {
                return i + " is the number you are looking for";
            }
        }
        return "Number not found";
    }
}