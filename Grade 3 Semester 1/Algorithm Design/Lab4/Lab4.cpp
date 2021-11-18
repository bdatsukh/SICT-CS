#include <iostream>
#include <vector>
#include <stack>

using namespace std;

int main()
{
	int N, K;
	cin >> N >> K;

	vector<int> flowers;
	stack<int> s;

	for(int i = 0; i < N; i++)
	{
		int temp;
		cin >> temp;

		flowers.push_back(temp);
		s.push(temp);
	}
	


	return 0;
}