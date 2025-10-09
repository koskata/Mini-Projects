#include <iostream>
#include <string>
#include <limits>

using namespace std;

// ===================== СТРУКТУРА НА ВЪЗЕЛ =====================
struct Node {
    string name;
    Node* next;
    Node(const string& s) : name(s), next(nullptr) {}
};

// ===================== ПРОТОТИПИ НА ФУНКЦИИ =====================
Node* createList(int n);
string josephusSelection(Node*& last, int k);
void deleteList(Node*& last);

// ===================== MAIN ФУНКЦИЯ =====================
int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cout << "Joseph: choice on every fourth armyman (Joseph, k=4)\n";

    int n;
    cout << "Enter number of armyman (n >= 1): ";
    while (!(cin >> n) || n < 1) {
        cout << "Please enter positive integer number: ";
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    // 1️ Създаваме цикличния списък
    Node* last = createList(n);

    // 2️ Прилагаме алгоритъма на Джоузеф
    const int k = 4;
    string chosen = josephusSelection(last, k);

    // 3️ Извеждаме резултата
    cout << "\nThe chosen one fot the mission is: " << chosen << "\n";

    // 4️ Изтриваме остатъчния възел
    deleteList(last);

    return 0;
}

// ===================== ФУНКЦИЯ: СЪЗДАВАНЕ НА СПИСЪК =====================
Node* createList(int n) {
    Node* last = nullptr;

    for (int i = 0; i < n; ++i) {
        cout << "Name of armyman " << (i + 1) << ": ";
        string s;
        getline(cin, s);
        if (s.empty()) { // ако натисне само Enter
            --i;
            continue;
        }

        Node* node = new Node(s);
        if (!last) {
            last = node;
            last->next = last; // първият сочи към себе си
        }
        else {
            node->next = last->next;
            last->next = node;
            last = node;
        }
    }

    return last;
}

// ===================== ФУНКЦИЯ: ИЗБОР НА ВОЙНИК =====================
string josephusSelection(Node*& last, int k) {
    if (!last)
        return "";

    Node* curr = last->next; // първият войник
    Node* prev = last;

    while (curr != prev) {
        for (int i = 1; i < k; ++i) {
            prev = curr;
            curr = curr->next;
        }

        cout << "Deleting: " << curr->name << '\n';
        prev->next = curr->next;
        delete curr;
        curr = prev->next;
    }

    string result = curr->name;
    return result;
}

// ===================== ФУНКЦИЯ: ИЗТРИВАНЕ НА СПИСЪКА =====================
void deleteList(Node*& last) {
    if (!last) return;

    Node* first = last->next;
    last->next = nullptr; // прекъсваме цикъла
    while (first) {
        Node* temp = first;
        first = first->next;
        delete temp;
    }
    last = nullptr;
}
