#include <iostream>
#include <vector>
#include <algorithm> // �� ��������� max

using namespace std;

int main() {
    int m, n;

    // ��������� �� ��������� �� ��������� �����
    cout << "Enter the number of rows (m): ";
    cin >> m;
    cout << "Enter the number of cols (n): ";
    cin >> n;

    // ����������� �� �������� �����
    vector<vector<int>> A(m, vector<int>(n));

    // ��������� �� ���������� �� ������
    cout << "�������� ���������� �� ������:" << endl;
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            cin >> A[i][j];
        }
    }

    // ��������� �� ������ b
    vector<int> b(m);

    for (int i = 0; i < m; ++i) {
        // �������� ����������� ������� � ����
        b[i] = A[i][0]; // �������������� � ������ �������
        for (int j = 1; j < n; ++j) {
            b[i] = max(b[i], A[i][j]); // ���������� ���������
        }
    }

    // ����������� �� ���������
    cout << "������� b ��� ����������� �� ����������� �: ";
    for (int i = 0; i < m; ++i) {
        cout << b[i] << " ";
    }
    cout << endl;

    return 0;
}
