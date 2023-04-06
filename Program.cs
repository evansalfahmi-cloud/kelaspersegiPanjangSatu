/*

Kelas sederhana
tentang persegi panjang
memiliki sisi yang disebut panjang dan lebar
rumus : panjang * lebar

alur

mendifinisikan kelas
Persegi panjang
berisi data panjang dan lebar

jadi
penulisan
class persegiPanjang 
{
    public double panjang;
    public double lebar;
}

untuk membuat objeknya
persegiPanjang cth = new persegiPanjang();

objek dari suatu kelas punya data sendiri sendiri
tidak terikan satu dengan yang lain


*/

using System;

//pendefinisian kelas persegiPanjang
class persegiPanjang {
    public double panjang;
    public double lebar;

}

//memembuat kelas main program
class DemoKelasPersegipanjang
{
    static void Main(){
        // membuat variabel baru untuk memuat hasil perkalian panjang * lebar 
        //inisiasi bernama luas
        double luas1;
        double luas2;

        //pembuatan objek persegiPanjang1
        persegiPanjang persegiPanjang1 = new persegiPanjang();
        //membuat objek persegiPanjang2
        persegiPanjang persegiPanjang2 = new persegiPanjang ();

        persegiPanjang1.panjang = 24;
        persegiPanjang1.lebar = 29;

        persegiPanjang2.panjang = 23;
        persegiPanjang2.lebar = 5;

        //menghitung luas persegiPanjang1
        luas1 = persegiPanjang1.panjang * persegiPanjang1.lebar;
        //menghitung luas persegiPanjang2
        luas2 = persegiPanjang2.panjang * persegiPanjang2.lebar;

        //tampil kan luas1 dan luas2;
        Console.WriteLine ("luas persegiPanjang1 adalah : "+luas1);
        Console.WriteLine("luas persegiPanjang2 adalah : "+luas2);

    }
}

