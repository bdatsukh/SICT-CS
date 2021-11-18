#include <iostream>
#include <stack>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7192/

int main()
{
    string str;
    cin >> str;

    stack<int> s;

    bool check = false;

    for (int i = 0; i < str.length(); i++)
    {
        if ('(' == str[i])
            s.push(1);

        if (s.size() > 0 && ')' == str[i])
            s.pop();
        else if (s.size() <= 0 && ')' == str[i])
        {
            check = true;
            break;
        }
    }

    if (s.size() == 0 && !check)
        cout << "GOOD" << endl;
    else
        cout << "NO" << endl;

    return 0;
}