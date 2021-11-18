#include <iostream>
#include <vector>

using namespace std;

int N = 4, K = 3;
int maxim = 0;
vector<int> v = {1, 7, 2, 4};
vector<int> subset;

void search(int i)
{
	if(i == v.size())
	{
		int count = 0;
		bool check = false;
		for(auto a : subset)
		{
			for(auto b : subset)
			{
				if(a != b && (a + b) % K == 0)
					count++;
				else
				{
					count = 0;
					check = true;
					break;
				}
			}

			if(check)
				break;
		}

		if(maxim < count)
			maxim = count;
	}
	else
	{
		search(i + 1);
		subset.push_back(v[i]);
		search(i + 1);
		subset.pop_back();
	}
}

int main(void)
{
	// cin >> N >> K;

	// for(int i = 0; i < N; i++)
	// {
	// 	int temp;
	// 	cin >> temp;

	// 	v.push_back(temp);
	// }

	search(0);

	cout << maxim << endl;

	return 0;
}