/*
kONSTRUKTOR

Metode khusus yang namanya sama dengan nama kelas dan akan dipanggil secara otomatis ketika proses pembuatan objek
contoh :
*/
using System;

class persegiPanjang {
    public double panjang ;
    public double lebar;

    //mendefinisikan konstruktor
    public persegiPanjang(){
        panjang = 8; 
        lebar =  9;
    }

    //mendefinisikan metode untuk ubah data
    public void ubahData ( double p , double l ){
        panjang = p;
        lebar = l;
    }

    //mendefinisikan metode untuk menghitung luas
    public double rumusLuas ()
    {
        return panjang * lebar;   
    }

    //mendifinisikan tampilkan hasil luas 
    public void tampilkanLuas (string s){
        Console.WriteLine(s + rumusLuas());
    }
}

class konstruktorDemo {
    static void Main () {
        persegiPanjang perPjg = new persegiPanjang ();

        //menampilkan luas dengan data awal
        perPjg.tampilkanLuas("Luas awal adalah = ");

        //merubah data panjang dan lebar
        perPjg.ubahData(13,7);

        //menampilkan luas dengan data baru
        perPjg.tampilkanLuas("Luas akhir adalah = ");
    }
}
