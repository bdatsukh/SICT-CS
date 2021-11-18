#include <iostream>
#include <string>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7538/

int main()
{
    string str1;
    string str2;

    cin >> str1 >> str2;

    string result = "";

    for (int i = 0; i < str1.length(); i++)
    {
        if (str1[i] != str2[i])
            result += "1";
        else
            result += "0";
    }

    cout << result << endl;

    return 0;
}