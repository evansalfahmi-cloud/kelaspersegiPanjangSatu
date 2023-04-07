/*
METODE
fungsi yang dibuat didalam kelas untuk melakukan tugas spesifik tertentu

2 Jenis
Nilai balik
tanpa nilai balik

/==================================================
METODE TANPA NILAI BALIK
=========================

PENDEFINISIAN MENGGUNAKAN KATA KUNCI VOID
Tipe akses vooid NAMAMETODE(daftar-parameter){
    //badan metode
}
*/

using System;

class persegiPanjang{
    public double panjang;
    public double lebar;

    //membat metode untuk rumus luas
    public void RumusLuas (){
        double luas;
        luas = panjang * lebar;
        Console.WriteLine("LUAS PERSEGI PANJANG = "+ luas);
    }
}

class metodeVoidDemo {
    static void Main (){
        persegiPanjang persegiPanjang1 = new persegiPanjang ();
        
        // memberikan nilai pada panjang lebar;
        persegiPanjang1.panjang = 23;
        persegiPanjang1.lebar = 24;
        
        Console.WriteLine ("persegi panjang 1 memiliki  panjang = "+ persegiPanjang1.panjang);
        Console.WriteLine ("persegi panjang 1 memiliki lebar    = "+ persegiPanjang1.lebar);
        //memanggil metode rumus luas
        persegiPanjang1.RumusLuas();

        }
}