#include <iostream>
#include <chrono>

using namespace std;
using namespace std::chrono;

int main()
{

    //Start measuring clock time. Clock time is the time it takes for the program to end for the user 
    auto start_2 = high_resolution_clock::now();

    //Start measuring CPU time. CPU time is the time it takes for the cpu to finish the execution of the program

    //Unoptimized lop sum
    int n = 100000;
    //int sum = 0;
    //for (int i = 0; i <= n; i++) {
      //  sum += i;
    //}


    //Optimized Loop sum
    long long sum = (static_cast<long long>(n) * (n + 1)) / 2;


    //End CPU time 

    //End clock time 
    auto stop_2 = high_resolution_clock::now();

    //CPU time in microseconds

    //Time for clock 
    auto real_duration = duration_cast<microseconds>(stop_2 - start_2);

    //Print results
    cout << "Real Time: " << real_duration.count() << " microseconds" << endl;
    cout << "Sum: " << sum << endl;

    return 0;
}



