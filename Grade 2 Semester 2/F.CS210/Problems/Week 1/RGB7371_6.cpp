#include <iostream>
#include <cmath>
#include <vector>

using namespace std;

////https://www.spoj.com/RGB7/problems/RGB7371/

int main()
{
    int N;
    cin >> N;

    vector<int> numbers;
    int cloneN = N;

    while (cloneN > 0)
    {
        numbers.push_back(cloneN % 10);
        cloneN /= 10;
    }

    int sum = 0;
    for (int j = 0; j < numbers.size(); j++)
    {
        sum += pow(numbers[j], numbers.size());
    }

    if (sum == N)
        cout << "YES" << endl;
    else
        cout << "NO" << endl;

    return 0;
}