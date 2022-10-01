#include <random>
#include <algorithm>
#include <iterator>
#include <iostream>
#include <vector>

using namespace std;

int findGCD(vector<int>& nums) {
    int minimum = nums[0], maximum = nums[0];
    for (int i = 1; i < nums.size(); i++)
    {
        minimum = min(minimum, nums[i]);
        maximum = max(maximum, nums[i]);
    }

    int gcd = 1;
    for (int i = 1; i <= minimum; i++)
    {
        if (minimum % i == 0 && maximum % i == 0)
            gcd = i;
    }
    return gcd;
}

int main()
{
    // First create an instance of an engine.
    random_device rnd_device;
    // Specify the engine and distribution.
    mt19937 mersenne_engine{ rnd_device() };  // Generates random integers
    uniform_int_distribution<int> dist{ 1, 100 };

    auto gen = [&dist, &mersenne_engine]() {
        return dist(mersenne_engine);
    };

    vector<int> vec(10);
    generate(begin(vec), end(vec), gen);

    cout << "Array: \n";

    for (auto i : vec) {
        cout << i << " ";
    }

    cout << "\n\n";

    int gcd = findGCD(vec);


    cout << "Answer: " << gcd << "\n";
}