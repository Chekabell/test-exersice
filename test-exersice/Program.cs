using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayRandomNumbers = new int[20];
        FillRand(arrayRandomNumbers);
        Console.Write("Massive of numbers: ");
        foreach(int number in arrayRandomNumbers)
        {
            Console.Write(number + "; ");
        }
        Console.WriteLine();
        Console.Write("Count of numbers which more then max number by abs: " + FindCountMaxByModule(arrayRandomNumbers));
    }

    private static void FillRand(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-15, 15);
        }
    }

    private static int FindCountMaxByModule(int[] array)
    {
        int count = 0;
        int max = array.Max();
        foreach (int number in array) 
        {
            if (Math.Abs(number) > max)
            {
                count++;
            }
        }
        return count;
    }
}