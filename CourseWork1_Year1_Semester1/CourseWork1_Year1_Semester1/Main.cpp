#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
	int m, n;

	cout << "Enter the number of rows (m): ";
	cin >> m;
	cout << "Enter the number of cols (n): ";
	cin >> n;

	vector<vector<int>> A(m, vector<int>(n));

	cout << "Enter the elements of array:" << endl;
	for (int i = 0; i < m; ++i) {
		for (int j = 0; j < n; ++j) {
			cin >> A[i][j];
		}
	}

	vector<int> b(m);

	for (int i = 0; i < m; ++i) {
		b[i] = A[i][0];
		for (int j = 1; j < n; ++j) {
			b[i] = max(b[i], A[i][j]);
		}
	}

	cout << "----------------------\n";
	cout << "Maximum elements of each row are: " << endl;
	for (int i = 0; i < m; ++i) {
		cout << "Maximal value of row " << i + 1 << ": " << b[i] << endl;
	}

	return 0;
}
