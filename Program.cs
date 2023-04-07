/*
METODE
fungsi yang dibuat didalam kelas untuk melakukan tugas spesifik tertentu

2 Jenis
Nilai balik
tanpa nilai balik

==========================
METODE TANPA NILAI BALIK
=========================

PENDEFINISIAN MENGGUNAKAN KATA KUNCI VOID
Tipe akses vooid NAMAMETODE(daftar-parameter){
    //badan metode
}

==========================
METODE DENGAN NILAI BALIK
==========================
PENDEFINISIAN
TipeAkses TipeKembalian NamaMetode(daftar-parameter){
    badan metode;
    return nilai;

}

METODE PARAMETER

PARAMETER : NILAI YANG DIMASUKKAN KE DALAM BADAN METODE

PERLU DIKETAHUI BAHWA PARAMETER YANG DIGUNAKAN DALAM PENDEFINISIAN METODE DISEBUT DENGAN PARAMETERFORMAL ATAU PARAMETER SAJA
SEDANGKAN NILAI PARAMETER YANG DISERTAKAN SAAT PEMANGGILAN METODE DISEBUT DENGAN ARGUMEN

karena metode ini akan mengembalikan nilai maka perlu di deklarasikan menggunakan tipe data

*/
using System; 

class persegiPanjang {
    public double panjang;
    public double lebar;

    //mendefinisikan metode dengan dua parameter
    public void isiData (double p, double l){
        panjang = p;
        lebar = l;        
    }
    //mendefinisikan metode untuk meghitung luas
    public double rumuasLuas(){
        return panjang * lebar ; 
    }

    //mendefinisian metode untuk menampilkan nilai luas
    public void tampilkanLuas (string s){
        Console.WriteLine (s + rumuasLuas());
    }
}

class demoMetodeParameter {
    static void Main (){
        persegiPanjang perPjg1 = new persegiPanjang(); // buat objek persegi panjang 1
        persegiPanjang perPjg2 = new persegiPanjang(); // buat objek persegi panjang 2
        
        perPjg1.isiData(7,6); // mengisi data persegi panjang 1 panjang dan lebar
        perPjg2.isiData(8,9); // mengisi data persegi panjang 2 panjang dan lebar

        //menampilkan nilai luas
        perPjg1.tampilkanLuas("luas persegi panjang 1 adalah = ");
        perPjg2.tampilkanLuas("luas persegi panjang 2 adalah = ");
        

    }
}