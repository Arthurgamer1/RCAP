// 331LinearSearch.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <random>
#include <chrono>

using namespace std;
using namespace std::chrono;


//Search the array linearly for the element
int linear_search(int arr[], int n, int x)
{
    for (int i = 0; i < n; i++)
    {
        if (arr[i] == x)
        {
            return i;
        }
    }
    return -1;

}

int main()
{

    //Start timer 
    auto clock_start = high_resolution_clock::now();
    auto cpu_start = high_resolution_clock::now();

    //Random timer
    srand(time(0));

    //Random number between 0-50
    int find_num = rand() % 51;


    //Array with numbers 
    int numbers[51] = {
        
        23, 7, 42, 18, 35, 11, 29, 50, 3, 27,
        15, 1, 46, 39, 9, 25, 6, 48, 31, 2,
        21, 13, 37, 4, 45, 17, 41, 0, 30, 19,
        12, 33, 8, 44, 24, 49, 5, 28, 40, 22,
        47, 16, 10, 26, 34, 36, 38, 32, 14, 20, 43 };


    //Print
    cout << "Finding the number: " << find_num << endl;


    //Return index or false value
    int return_value = linear_search(numbers, 51, find_num);


    //Check conditions for if the number is found
    if (return_value != -1)
    {
        cout << "Number found in the array in index " << return_value << endl;

    }
    else
    {
        cout << "Number not found" << endl;

    }


    //Timer stops 
    auto clock_stop = high_resolution_clock::now();
    auto cpu_stop = high_resolution_clock::now();


    //Calculate the time
    auto cpu_duration = duration_cast<microseconds>(cpu_stop - cpu_start);
    auto real_duration = duration_cast<microseconds>(clock_stop - clock_start);


    //Print
    cout << "CPU Time: " << cpu_duration.count() << " microseconds" << endl;
    cout << "Real Time: " << real_duration.count() << " microseconds" << endl;

    return 0;
    


}

