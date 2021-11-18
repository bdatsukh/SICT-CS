#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7755/

void _swap(int &a, int &b)
{
    int temp = a;
    a = b;
    b = temp;
}

int partition(int *arr, int L, int R)
{
    int M = L + (R - L) / 2;

    while (true)
    {
        while (arr[L] < arr[M])
            L++;

        while (arr[M] < arr[R])
            R--;

        if (L >= R)
            return R;

        _swap(arr[L], arr[R]);

        L++;
        R--;
    }
}

void quickSort(int *arr, int L, int R)
{
    if (L >= R)
        return;

    int pivot = partition(arr, L, R);

    quickSort(arr, L, pivot);
    quickSort(arr, pivot + 1, R);
}

int main()
{
    int N, K;
    cin >> N >> K;

    int arr[N];

    for (int i = 0; i < N; i++)
        cin >> arr[i];

    quickSort(arr, 0, N - 1);

    int min = 1e9 + 1;
    for (int i = 0; i <= N - K; i++)
    {
        int localMin = arr[i];
        int localMax = arr[i + K - 1];

        if (min > localMax - localMin)
            min = localMax - localMin;
    }

    cout << min << endl;

    return 0;
}