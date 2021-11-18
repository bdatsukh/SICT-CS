#include <iostream>

using namespace std;

//https://www.spoj.c./om/RGB7/problems/RGB7440/

int main()
{
    char c;
    cin >> c;

    string result = "";

    while (c != 'Z' + 1)
    {
        result += c++;
        cout << result << endl;
    }
    cout << endl;

    return 0;
}