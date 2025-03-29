#include <iostream>
#include <chrono>

using namespace std;
using namespace std::chrono;

int main()
{

    //Start measuring clock time. Clock time is the time it takes for the program to end for the user 
    auto start_2 = high_resolution_clock::now();

    //Start measuring CPU time. CPU time is the time it takes for the cpu to finish the execution of the program
    auto cpu_start = high_resolution_clock::now();

    //Loop Sum
    int sum = 0;
    int n = 1000000;
    for (int i = 0; i < n; i++) {
        sum += i;
    }

    //End CPU time 
    auto cpu_stop = high_resolution_clock::now();

    //End clock time 
    auto stop_2 = high_resolution_clock::now();

    //CPU time in microseconds
    auto cpu_duration = duration_cast<microseconds>(cpu_stop - cpu_start);

    //Time for clock 
    auto real_duration = duration_cast<microseconds>(stop_2 - start_2);

    //Print results
    cout << "CPU Time: " << cpu_duration.count() << " microseconds" << endl;
    cout << "Real Time: " << real_duration.count() << " microseconds" << endl;
    cout << "Sum: " << sum << endl;

    return 0;
}



