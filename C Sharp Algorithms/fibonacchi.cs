using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fibonacchi
{
    class Program
    {
        // 📌 Fibonacci using List
        static List<int> FibonacciList(int n)
        {
            List<int> fibList = new List<int> { 0, 1 };

            for (int i = 2; i < n; i++)
            {
                fibList.Add(fibList[i - 1] + fibList[i - 2]);
            }

            return fibList;
        }

        // 📌 Fibonacci using Recursion
        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // 📌 Prints Fibonacci sequence and sum
        static void PrintFibonacciResults(List<int> sequence)
        {
            Console.WriteLine("Fibonacci Sequence: " + string.Join(", ", sequence));

            int sum = 0;
            foreach (int num in sequence)
            {
                sum += num;
            }
            Console.WriteLine($"Sum of first {sequence.Count} Fibonacci numbers: {sum}");
        }

        static void PrintPerformanceMetrics(Stopwatch stopwatch)
        {
            Process currentProcess = Process.GetCurrentProcess();

            Console.WriteLine($"\n==== Performance Metrics ====");
            Console.WriteLine($"- Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"- CPU Time: {currentProcess.TotalProcessorTime.TotalMilliseconds} ms");
            Console.WriteLine($"- Memory Usage: {currentProcess.WorkingSet64 / 1024} KB");
        }

        static void MenuPrompt()
        {
            Console.Clear();
            Console.WriteLine("==== Fibonacci Calculator ====\n");
            Console.WriteLine("Welcome, this is a simple program to test different algorithms in C#. " +
                "Please select the algorithm by propting the number in the list. For example 1 will select " +
                "\"Fibonnacci using List\". The list of algorithms is the following: \n \n");
            Console.WriteLine("1. Fibonacci using List: Will return a list of specified number of terms in the sequence.");
            Console.WriteLine("2. Fibonacci using Recursion: Will calculate and return " +
                "the espcified value on the postion chosen of the fibonacci sequence. " +
                "Ex. Choice is 6, so the 6th number is 8 starting from 0");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
        }

        static void Main()
        {
            while (true)
            {
                MenuPrompt();

                string choice = Console.ReadLine();
                int n;
                List<int> fibonacciSeries = new List<int>();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the number of Fibonacci terms: ");
                        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0) // Checks for invalid inputs
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                            break;
                        }

                        Stopwatch stopwatch1 = Stopwatch.StartNew(); //Uses metrics and record it until it stops
                        fibonacciSeries = FibonacciList(n);
                        stopwatch1.Stop(); // Stop metrics once calculation is done

                        PrintFibonacciResults(fibonacciSeries);
                        PrintPerformanceMetrics(stopwatch1);
                        break;

                    case "2":
                        Console.Write("Enter the number of Fibonacci terms: ");
                        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                            break;
                        }
                        Stopwatch stopwatch2 = Stopwatch.StartNew();
                        for (int i = 0; i < n; i++)
                        {
                            fibonacciSeries.Add(FibonacciRecursive(i)); // Adds
                        }
                        stopwatch2.Stop();
                        PrintFibonacciResults(fibonacciSeries);
                        PrintPerformanceMetrics(stopwatch2);
                        break;

                    case "0":
                        Console.WriteLine("Exiting program...");
                        return; // Exit the loop and program

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}

