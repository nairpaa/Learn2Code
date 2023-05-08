#include <iostream>

using namespace std;

// Deklarasi struct
struct Mahasiswa {
    string npm, nama, jurusan;
    int umur;
    string hobi[3];
} mhs1, mhs2; // Deklarasi variable struct langsung (global)

int main(){

    // Pengisian data ke-1
    mhs1.npm = "141414";
    mhs1.nama = "Yanto";
    mhs1.jurusan = "Teknik Industri";
    mhs1.umur = 20;
    mhs1.hobi[0] = "Baca";
    mhs1.hobi[1] = "Renang";
    mhs1.hobi[2] = "Panahan";

    // Cara pengisian data ke-2
    // Catatan: harus berurutan
    mhs2 = {"232323", "Beti", "Sosiologi", 21, {"Game", "Design", "Tinju"}};

    // Deklarasi variable struct (lokal)
    // Cara pengisian data ke-3
    Mahasiswa mhs3 = {"6565656", "Amin", "Ilmu Komunikasi", 19, {"Baca", "Ngaji", "Tinju"}};

    // Print output
    cout << "Data-1: " << endl; 
    cout << "NPM: " << mhs1.npm << endl;
    cout << "Nama: " << mhs1.nama << endl;
    cout << "Jurusan: " << mhs1.jurusan << endl;
    cout << "Umur: " << mhs1.umur << endl;
    cout << "Hobi 1: " << mhs1.hobi[0] << endl;
    cout << "Hobi 2: " << mhs1.hobi[1] << endl;
    cout << "Hobi 3: " << mhs1.hobi[2] << endl;

    cout << endl;

    cout << "Data-2: " << endl;
    cout << "NPM: " << mhs2.npm << endl;
    cout << "Nama: " << mhs2.nama << endl;
    cout << "Jurusan: " << mhs2.jurusan << endl;
    cout << "Umur: " << mhs2.umur << endl;
    cout << "Hobi 1: " << mhs2.hobi[0] << endl;
    cout << "Hobi 2: " << mhs2.hobi[1] << endl;
    cout << "Hobi 3: " << mhs2.hobi[2] << endl;

    cout << endl;

    cout << "Data-3: " << endl;
    cout << "NPM: " << mhs3.npm << endl;
    cout << "Nama: " << mhs3.nama << endl;
    cout << "Jurusan: " << mhs3.jurusan << endl;
    cout << "Umur: " << mhs3.umur << endl;
    cout << "Hobi 1: " << mhs3.hobi[0] << endl;
    cout << "Hobi 2: " << mhs3.hobi[1] << endl;
    cout << "Hobi 3: " << mhs3.hobi[2] << endl;


    return 0;
}