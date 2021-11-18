#include <iostream>

using namespace std;

int main(void)
{
	int N, K;
	cin >> N >> K;

	int max = 0;
	for(int i = 0; i < N; i++)
	{
		int temp;
		cin >> temp;

		if(max < temp)
			max = temp;
	}

	cout << (K >= max ? 0 : max - K) << endl;

	return 0;
}