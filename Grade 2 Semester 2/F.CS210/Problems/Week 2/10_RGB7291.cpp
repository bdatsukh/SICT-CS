#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7291/
int main()
{
    int N, M;
    cin >> N >> M;
    int sum = 0;
    int before = 1;
    for (int i = 0; i < M; i++)
    {
        int temp;
        cin >> temp;

        if (before <= temp)
            sum += (temp - before);
        else
            sum += (N - before + temp);

        before = temp;
    }

    cout << sum << endl;

    return 0;
}