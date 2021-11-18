#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7909/

void addOne(int *arr, int l, int r);

int main()
{
    int N, K;
    cin >> N >> K;

    int arr[N + 2] = {0};

    for (int i = 0; i < K; i++)
    {
        int A, B;
        cin >> A >> B;

        addOne(arr, A, B);
    }

    for (int i = 1; i < N; i++)
    {
        for (int j = i + 1; j <= N; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    int mid = 1 + (N - 1) / 2;
    cout << arr[mid] << endl;

    return 0;
}

void addOne(int *arr, int l, int r)
{
    while (l <= r)
    {
        arr[l] += 1;
        l++;
    }
}