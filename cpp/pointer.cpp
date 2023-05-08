#include <iostream>

using namespace std;

int main(){
    
    int nilai = 5;

    int *ptrNilai1;
    ptrNilai1 = &nilai;

    int *ptrNilai2 = &nilai;

    cout << "Alamat dari variable nilai: " << &nilai << endl;
    cout << "Isi dari ptrNilai1: " << *ptrNilai1 << endl;
    (*ptrNilai1)++;
    cout << "Isi dari ptrNilai2: " << *ptrNilai2 << endl;
    
    return 0;
}