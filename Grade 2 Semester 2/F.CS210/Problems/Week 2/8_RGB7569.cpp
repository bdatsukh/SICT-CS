#include <iostream>
#include <vector>

using namespace std;

// https://www.spoj.com/RGB7/problems/RGB7569/

int main()
{
    int N, K;
    cin >> N >> K;
    cin.ignore();

    string str;
    getline(cin, str);

    string temp = "";
    vector<string> result;
    for (int i = 0; i < str.size(); i++)
    {
        if (str[i] != ' ')
            temp += str[i];
        else
        {
            result.push_back(temp);
            temp = "";
        }
    }

    result.push_back(temp);

    int count = 0;
    temp = "";
    for (int i = 0; i < result.size(); i++)
    {
        if (count + result[i].size() <= K)
        {
            count += result[i].size();
            temp += (temp == "" ? result[i] : " " + result[i]);
        }
        else
        {
            cout << temp << endl;
            count = result[i].size();
            temp = result[i];
        }
    }

    cout << temp << endl;

    return 0;
}