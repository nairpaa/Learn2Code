#include <iostream>

using namespace std;


// Deklarasi struct
struct Kampus {
    string namaKampus, alamatKampus;
    int tahunBerdiri;
};

struct Mahasiswa {
    string npm, nama, jurusan;
    int umur;
    Kampus kps; // Nested struct (1)
    struct AlamatMhs { // Nested struct (2)
        string jalan;
    } alamat;
    string hobi[3];
};

void cetakDataMahasiswa(Mahasiswa data) {
    cout << "> Data Mahasiswa: " << endl; 
    cout << "NPM: " << data.npm << endl;
    cout << "Nama: " << data.nama << endl;
    cout << "Jurusan: " << data.jurusan << endl;
    cout << "Umur: " << data.umur << endl;
    cout << "Alamat: " << data.alamat.jalan << endl;
    cout << "Hobi 1: " << data.hobi[0] << endl;
    cout << "Hobi 2: " << data.hobi[1] << endl;
    cout << "Hobi 3: " << data.hobi[2] << endl;
    cout << "Nama Kampus: " << data.kps.namaKampus << endl;
    cout << "Alamat Kampus: " << data.kps.alamatKampus << endl;
    cout << "Tahun Berdiri: " << data.kps.tahunBerdiri << endl;
}

int main(){

    // Array dari struct
    Mahasiswa mhs[3];

    Kampus kampusUtama = {"Universitas Tertutup", "Jl. Cimenyan No. 12", 1999};

    // Pengisian data ke-1
    mhs[0].npm = "141414";
    mhs[0].nama = "Yanto";
    mhs[0].jurusan = "Teknik Industri";
    mhs[0].umur = 20;
    mhs[0].hobi[0] = "Baca";
    mhs[0].hobi[1] = "Renang";
    mhs[0].hobi[2] = "Panahan";
    mhs[0].kps = kampusUtama;
    mhs[0].alamat.jalan = "Jl. Cicadas No. 18";

    // Print output data ke-1
    cetakDataMahasiswa(mhs[0]);

    cout << endl;

    // Pengisian data ke-2
    mhs[1].npm = "787878";
    mhs[1].nama = "Beti";
    mhs[1].jurusan = "Ilmu Komunikasi";
    mhs[1].umur = 20;
    mhs[1].hobi[0] = "Tinju";
    mhs[1].hobi[1] = "Game";
    mhs[1].hobi[2] = "Panahan";
    mhs[1].kps = kampusUtama;
    mhs[1].alamat.jalan = "Jl. Cicadas No. 18";

    // Print output data ke-2
    cetakDataMahasiswa(mhs[1]);

    return 0;
}