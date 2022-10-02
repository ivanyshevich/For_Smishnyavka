#include <random>
#include <algorithm>
#include <iterator>
#include <iostream>
#include <vector>
#include <numeric>

using namespace std;

int gcd(int a, int b)
{
    if (a == 0)
        return b;
    return gcd(b % a, a);
}

// Function to find gcd of array of
// numbers
int findGCD(int arr[], int n)
{
    int result = arr[0];
    for (int i = 1; i < n; i++)
        result = gcd(arr[i], result);

    return result;
}

int main()
{
    //int arr[] = { 8, 4, 12, 24 };
    int arr[10];
    random_device rd;
    default_random_engine dre(rd());
    uniform_int_distribution<int> uid(1, 100);

    generate(arr, arr + sizeof(arr) / sizeof(int), [&]() { return uid(dre); });

    cout << "Array: \n";

    for (int a : arr)
        if (a == 0)
            cout << "Cannot have 0 within the array";
        else
            cout << a << " ";

    int n = sizeof(arr) / sizeof(arr[0]);
    cout << "\n\n" << "Answer: " << findGCD(arr, n) << endl;

    return 0;
}
