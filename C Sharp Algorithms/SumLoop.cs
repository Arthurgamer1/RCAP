using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{

    // 📌 Summation Loop
    static void SumLoop(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"You result is {sum}!\n");
    }

    static void MenuPrompt()
    {
        Console.Clear();
        Console.WriteLine("==== Simple Sum Algorithm====\n");
        Console.WriteLine("Welcome, this is a simple program to test different algorithms in C#. " +
            "Please select the algorithm by propting the number in the list. For example 1 will select " +
            "\"Fibonnacci using List\". The list of algorithms is the following: \n \n");
        Console.WriteLine("1. Simple Sum Loop: Will add from 0 to the specified number. This is a simple test for runtime.");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
    }
    static void Main()
    {
        MenuPrompt();

        string choice = Console.ReadLine();

        int n;
        switch (choice)
        {
            case "1":
                Console.Write("Select the upper limit of the sum from 0:");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    break;
                }
                Stopwatch stopwatch7 = Stopwatch.StartNew();
                SumLoop(n);
                stopwatch7.Stop();
                PrintPerformanceMetrics(stopwatch7);
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
