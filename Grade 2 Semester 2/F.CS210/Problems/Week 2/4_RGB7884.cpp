#include <iostream>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7884/

int main()
{
    int N, K;
    cin >> N >> K;

    int sum = 0;
    int bill;

    for (int i = 0; i < N; i++)
    {
        int temp;
        cin >> temp;

        sum += temp;

        if (i == K)
            bill = temp;
    }

    double temp = (sum - bill) / 2;
    double anna;
    cin >> anna;

    if (temp == anna)
        cout << "Bon Appetit" << endl;
    else
        cout << anna - temp << endl;

    return 0;
}