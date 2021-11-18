#include <iostream>
#include <vector>
#include <map>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7752/

int main()
{
    int N;
    cin >> N;

    map<int, int> m;

    for (int i = 0; i < N; i++)
    {
        int temp;
        cin >> temp;

        m[temp]++;
    }

    int count = 0, check = N;
    for (int i = 0; i < N; i++)
    {
        int temp;
        cin >> temp;

        if (m[temp] > 0)
        {
            m[temp]--;
            count++;
            check--;
        }
    }

    cout << ((check != 0) ? count + 1 : count - 1) << endl;

    return 0;
}