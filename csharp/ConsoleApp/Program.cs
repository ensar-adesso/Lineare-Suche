﻿using System;

public class Program
{
    static int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the number you want to search for: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(lineare_serach(number));
        Console.WriteLine(binary_search(number, 0, Numbers.Length - 1));
    }

    private static String lineare_serach(int number)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (Numbers[i] == number)
            {
                return Numbers[i] + " is the number you are looking for and it is at index " + i;
            }
        }
        return "Number not found";
    }

    private static String binary_search(int value, int start, int end)
    {
        if (start > end)
        {
            return "Number not found";
        }

        int middle = (start + end) / 2;

        if (Numbers[middle] == value)
        {
            return Numbers[middle] + " is the number you are looking for and it is at index " + middle;
        }

        if (value < Numbers[middle])
        {
            return binary_search(value, start, middle - 1);
        }
        else
        {
            return binary_search(value, middle + 1, end);
        }
    }
}