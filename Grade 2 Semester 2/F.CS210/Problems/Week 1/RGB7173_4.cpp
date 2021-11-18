#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7173/

int main()
{
    string result[] = {"I", "II", "III", "IV"};

    int x, y;
    cin >> x >> y;

    if (x > 0 && y > 0)
        cout << result[0] << endl;
    else if (x < 0 && y > 0)
        cout << result[1] << endl;
    else if (x < 0 && y < 0)
        cout << result[2] << endl;
    else
        cout << result[3] << endl;

    return 0;
}