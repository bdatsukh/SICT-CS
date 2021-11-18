#include <iostream>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7370/

int main()
{
    int K;
    string bigNubmer;

    cin >> K;
    cin >> bigNubmer;

    int sumOfEven = 0, sumOfOdd = 0;
    for (int i = 0; i < bigNubmer.length(); i++)
    {
        if (i % 2 == 0)
            sumOfOdd += bigNubmer[i] - 48;
        else
            sumOfEven += bigNubmer[i] - 48;
    }

    if (abs(sumOfEven - sumOfOdd) % K == 0)
        cout << "YES" << endl;
    else
        cout << "NO" << endl;

    return 0;
}