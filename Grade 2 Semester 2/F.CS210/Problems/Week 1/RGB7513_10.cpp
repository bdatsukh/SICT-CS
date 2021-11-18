#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7513/

void reverse(int *arr, int l, int r)
{
    while (l <= r)
    {
        int temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;
        r--;
        l++;
    }
}

int main()
{
    int N, a, b, c, d;
    cin >> N >> a >> b >> c >> d;

    int arr[N + 2] = {0};

    for (int i = 1; i <= N; i++)
        arr[i] = i;

    reverse(arr, a, b);
    reverse(arr, c, d);

    for (int i = 1; i <= N; i++)
        cout << arr[i] << " ";

    cout << endl;

    return 0;
}