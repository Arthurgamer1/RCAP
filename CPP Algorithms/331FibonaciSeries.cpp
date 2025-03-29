// 331FibonaciSeries.cpp : This file contains the 'main' function. Program execution begins and ends there.

#include <iostream>
#include <chrono>
using namespace std;

using namespace std::chrono;


//Fibo function
int fibo(int n)
{

    if (n == 0)
    {

        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return fibo(n - 1) + fibo(n - 2);

    }
};

int main()
{
    //Start timer 
    auto clock_start = high_resolution_clock::now();
    auto cpu_start = high_resolution_clock::now();
    
    //Value for loop
    int val_loop = 20;

  

    cout<< "The sum is " << fibo(val_loop) << endl;

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

