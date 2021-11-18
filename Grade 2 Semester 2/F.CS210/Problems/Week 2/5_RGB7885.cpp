#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7885/

int main()
{
    int N, K;
    cin >> N >> K;

    int arr[N];

    for (int i = 0; i < N; i++)
        cin >> arr[i];

    int count = 0;
    for (int i = 0; i < N - 1; i++)
        for (int j = i + 1; j < N; j++)
            if ((arr[i] + arr[j]) % K == 0)
                count++;

    cout << count << endl;

    return 0;
}