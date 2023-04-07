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

karena metode ini akan mengembalikan nilai maka perlu di deklarasikan menggunakan tipe data

*/

using System ;
class persegiPanjang {
    public double panjang;
    public double lebar;
    
    //mendefinisikan metode rumusLuas
    public double rumusHitungLuas (){
        double luas ;
        luas = panjang * lebar;
        return luas; //mengembalikan nilai
    }
}

class DemoMetodePengembalianNilai {
    static void Main (){
        persegiPanjang persegiPanjang1= new persegiPanjang ();

        //isi data
        persegiPanjang1.panjang = 5;
        persegiPanjang1.lebar = 7;

        //memanggil metode rumusHitungLuas ()
        double L = persegiPanjang1.rumusHitungLuas();

        //menampilkan luas
        Console.WriteLine("luas persegi panjang 1 adalah = "+ L);
    }
}