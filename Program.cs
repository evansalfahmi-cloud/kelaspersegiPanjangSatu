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
        double luas;

        //pembuatan objek persegiPanjang
        persegiPanjang cth = new persegiPanjang();

        //memuat data persegii panjang
        cth.panjang = 10 ; 
        cth.lebar = 25;

        //membuat perhituang luas persegiPanjang 
        luas = cth.panjang * cth.lebar;
        
        //memuat/ tampilkan nilai luas
        Console.WriteLine("Luas persegi panjang adalah : " + luas);

    }
}

