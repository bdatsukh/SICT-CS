#include <iostream>
#include <map>
#include <vector>
#include <algorithm>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7917/

int main()
{
    int N;
    cin >> N;

    map<int, vector<int>> m;
    vector<int> q;

    for (int i = 0; i < N; i++)
    {
        int temp;
        cin >> temp;

        q.push_back(temp);
        m[temp].push_back(i);
    }

    int max = 0;
    for (map<int, vector<int>>::iterator it = m.begin(); it != m.end(); ++it)
    {
        int count = 0;
        int before = -1;

        for (int i = it->second[0], idx = 0; i <= it->second[it->second.size() - 1]; i++)
        {
            if (it->second[idx] == i)
            {
                idx++;
                count++;
            }
            else if (before == -1 || before == q[i])
            {
                before = q[i];
            }
            else
            {
                if (max < count)
                    max = count;

                count = 1;
                before = -1;
            }
        }

        if (max < count)
            max = count;
    }

    cout << max << endl;

    for (int i = 0; i < q.size(); i++)
        cout << q[i] << " ";
    cout << endl;

    for (map<int, vector<int>>::iterator it = m.begin(); it != m.end(); ++it)
    {
        cout << it->first << ": ";
        for (int i = 0; i < it->second.size(); i++)
            cout << it->second[i] << " ";
        cout << endl;
    }

    return 0;
}