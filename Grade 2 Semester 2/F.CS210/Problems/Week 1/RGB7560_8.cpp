#include <iostream>
#include <iomanip>

using namespace std;

//https://www.spoj.com/RGB7/problems/RGB7560/

int main()
{
    int N;
    cin >> N;

    double nums[N];
    int max = 0, min = 0;
    for (int i = 0; i < N; i++)
    {
        cin >> nums[i];

        if (i == 0)
        {
            max = i;
            min = i;
        }

        if (i != 0 && nums[max] < nums[i])
            max = i;

        if (i != 0 && nums[min] > nums[i])
            min = i;
    }

    double temp = nums[max];
    nums[max] = nums[min];
    nums[min] = temp;

    cout << setprecision(2);
    cout << fixed;

    for (int i = 0; i < N; i++)
        cout << nums[i] << " ";

    cout << endl;

    return 0;
}