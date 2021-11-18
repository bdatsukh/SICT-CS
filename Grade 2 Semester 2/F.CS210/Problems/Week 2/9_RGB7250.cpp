#include <iostream>
#include <algorithm>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7250/

bool funct(string str1, string str2);

int main()
{
    string str1, str2;
    cin >> str1 >> str2;

    cout << (funct(str1, str2) ? "OK" : "WRONG_ANSWER");

    return 0;
}

bool funct(string str1, string str2)
{
    sort(str1.begin(), str1.end());

    int i = 0;
    while (str1[i] == '0')
        i++;

    swap(str1[0], str1[i]);

    return (str1 == str2 ? true : false);
}