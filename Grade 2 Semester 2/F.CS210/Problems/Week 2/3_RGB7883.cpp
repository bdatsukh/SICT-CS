#include <iostream>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7883/

int main()
{
    int arr[6] = {0};
    int N;
    cin >> N;

    for (int i = 0; i < N; i++)
    {
        int temp;
        cin >> temp;

        arr[temp]++;
    }

    int max = 0;
    int result;
    for (int i = 1; i <= 5; i++)
        if (max < arr[i])
        {
            max = arr[i];
            result = i;
        }

    cout << result << endl;

    return 0;
}