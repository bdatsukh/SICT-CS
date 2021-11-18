#include <iostream>
#include <climits>

using namespace std;

void merge(int *, int, int, int);
void mergeSort(int *, int, int);

int main()
{
    /*
    int N, D;
    cin >> N >> D;

    int A[N] = {0};
    for (int i = 0; i < N; i++)
    {
        cin >> A[i];
    }

    int M;
    cin >> M;
    */
    int arr[] = {1231, -1234, 1, 2, 1, 12, 32};
    int N = sizeof(arr) / sizeof(arr[0]);

    mergeSort(arr, 0, N - 1);

    for (int i = 0; i < N; i++)
        cout << arr[i] << " ";

    cout << endl;

    return 0;
}

void merge(int *arr, int L, int M, int R)
{
    int LN = M - L + 1 + 1;
    int RN = R - (M + 1) + 1 + 1;

    int X[LN];
    int Y[RN];

    X[LN - 1] = INT_MAX;
    Y[RN - 1] = INT_MAX;

    for (int i = 0; i < LN - 1; i++)
        X[i] = arr[L + i];

    for (int i = 0; i < RN - 1; i++)
        Y[i] = arr[(M + 1) + i];

    int xi = 0;
    int yi = 0;
    for (int i = L; i < R + 1; i++)
    {
        if (X[xi] < Y[yi])
            arr[i] = X[xi++];
        else
            arr[i] = Y[yi++];
    }
}

void mergeSort(int *arr, int L, int R)
{
    if (L >= R)
        return;

    int M = L + (R - L) / 2;

    mergeSort(arr, L, M);
    mergeSort(arr, M + 1, R);
    merge(arr, L, M, R);
}
