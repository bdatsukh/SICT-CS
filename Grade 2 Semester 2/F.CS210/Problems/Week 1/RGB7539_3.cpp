#include <iostream>
#include <string>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7539/

int main()
{
    string dp = "hello";
    string str;
    cin >> str;

    bool check = false;
    int j = 0;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == dp[j])
        {
            j++;

            if (j >= dp.length())
            {
                check = true;
                break;
            }
        }
    }

    if (check)
        cout << "YES" << endl;
    else
        cout << "NO" << endl;

    return 0;
}