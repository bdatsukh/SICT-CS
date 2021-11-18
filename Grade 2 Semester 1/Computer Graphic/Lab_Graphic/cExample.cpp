#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

double efficientRate(double rate, int month){
	double result = 0; 

	result = pow(1 + ((rate / 100) / 12), month) - 1;

	return result;
}

int main(){
	double deposit;
	double rate;

	cout << "deposit = ";
	cin >> deposit;
	cout << "rate = ";
	cin >> rate;

	cout << fixed << setprecision(2);
	
	double beginnigBalance = deposit;
	double interestedEarned = 0;
	double endingBalance = deposit;

	for(int month = 1; month <= 12; month++){
		beginnigBalance = endingBalance;
		interestedEarned = deposit * efficientRate(rate, month);
		endingBalance = interestedEarned + deposit;

		cout << month << " " << beginnigBalance << " " << interestedEarned << " " << endingBalance << endl;
	}

	return 0;
	
}