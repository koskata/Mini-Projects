#include <iostream>
#include <vector>
#include <algorithm> // За функцията max

using namespace std;

int main() {
    int m, n;

    // Въвеждане на размерите на двумерния масив
    cout << "Enter the number of rows (m): ";
    cin >> m;
    cout << "Enter the number of cols (n): ";
    cin >> n;

    // Деклариране на двумерен масив
    vector<vector<int>> A(m, vector<int>(n));

    // Въвеждане на елементите на масива
    cout << "Въведете елементите на масива:" << endl;
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            cin >> A[i][j];
        }
    }

    // Създаване на масива b
    vector<int> b(m);

    for (int i = 0; i < m; ++i) {
        // Намерете максималния елемент в реда
        b[i] = A[i][0]; // Инициализираме с първия елемент
        for (int j = 1; j < n; ++j) {
            b[i] = max(b[i], A[i][j]); // Обновяваме максимума
        }
    }

    // Отпечатване на резултата
    cout << "Масивът b със стойностите на максимумите е: ";
    for (int i = 0; i < m; ++i) {
        cout << b[i] << " ";
    }
    cout << endl;

    return 0;
}
