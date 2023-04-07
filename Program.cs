/*
contoh
KONSTRUKTOR DENGAN PARAMETER
*/
using System;

class persegiPanjang {
    public double panjang ;
    public double lebar;

    //mendefinisikan konstruktor
    public persegiPanjang (double p , double l){
        panjang = p ;
        lebar = l;
    }

    //mendefinisikan metode untuk rubah data
    public void rubahData (double p , double l){
        panjang = p ;
        lebar = l ;
    }

    //membuat metode/ rumus menghitung luas pesegi panjang
    public double rumusLuas (){
        return panjang * lebar;
    }

    //membuat tampilkan luas persegi panjang
    public void tampilkanLuas (string s){
        Console.WriteLine(s+rumusLuas());
    }
    
}

class demoKonstruktoParameter
{
    static void Main (){
        persegiPanjang perPjg1 = new persegiPanjang(9,8);
        persegiPanjang perPjg2 = new persegiPanjang(12,7);

        perPjg1.tampilkanLuas("LUAS PERSEGIPANJANG PERTAMA : ");
        perPjg2.tampilkanLuas("LUAS PERSEGIPANJANG KEDUA   : ");


    }
}