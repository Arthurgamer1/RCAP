using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{

    // 📌 Reads the number file and uses Linear Search to find the desired number
    static int LinearSearch(int[] arr, int n, int x)
    {
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                Console.WriteLine($"Number found on list, the number is {x} !");
                return i;
            }
        }
        Console.WriteLine("Your coudn't be found.");
        return -1;
    }

    static void MenuPrompt()
    {
        Console.Clear();
        Console.WriteLine("==== Linear Search Algorithm====\n");
        Console.WriteLine("Welcome, this is a simple program to test different algorithms in C#. " +
            "Please select the algorithm by propting the number in the list. For example 1 will select " +
            "\"Fibonnacci using List\". The list of algorithms is the following: \n \n");
        Console.WriteLine("1. Linear Search: Iterates to find if number exist in the numbers.txt file");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
    }
    static void Main()
    {
        string numListPath = @"../Numbers.csv"; // Modify this to your file path
        string choice = Console.ReadLine();

        int n;
        switch (choice)
        {
            case "1":
                int[] numbers = File.ReadAllLines(numListPath).Select(int.Parse).ToArray();

                // Print the numbers
                Console.WriteLine("Numbers in array: \n");
                Console.WriteLine(string.Join(", ", numbers));

                Console.Write("Select a number to find: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    break;
                }
                Stopwatch stopwatch6 = Stopwatch.StartNew();
                LinearSearch(numbers, numbers.Length, n);
                stopwatch6.Stop();
                PrintPerformanceMetrics(stopwatch6);
                break;

            case "0":
                Console.WriteLine("Exiting program...");
                return; // Exit the loop and program

            default:
                Console.Write("Invalid choice. Please try again.");
                break;
        }
    }
}
