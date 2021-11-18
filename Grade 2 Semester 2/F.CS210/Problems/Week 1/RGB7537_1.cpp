#include <iostream>
#include <vector>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7537/

int main()
{
    int dp[] = {4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 774, 777};
    int N;

    cout << "N: ";
    cin >> N;

    for (int i = 0; i < sizeof(dp) / sizeof(dp[0]); i++)
    {
        if (N % dp[i] == 0)
        {
            cout << "YES" << endl;

            return 0;
        }
    }

    cout << "NO" << endl;

    return 0;
}