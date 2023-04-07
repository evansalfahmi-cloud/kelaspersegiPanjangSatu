/*
OVERLOAD TERHADAP KONSTRUKTOR
untuk membedakan segi empat berupa persegi panjang atau bujursangkar

CONTOH
*/
using System;
class segiEmpat {
    double panjang;
    double lebar;

    //membuat konstruktor pesegi panjang 
    public segiEmpat (double p , double l){
        panjang = p ;
        lebar = l;
    }

    //konstrktor untuk bujur sangkar
    public segiEmpat (double sisi){
        panjang = lebar = sisi ;
    }

    private double rumusLuas (){
        return panjang * lebar;
    }

    public void tampilkanLuas (string s){
        Console.WriteLine(s+rumusLuas());
    }
}

class demoKonstruktorOverload {
    static void Main (){
        //membuat objek persegi panjang
        segiEmpat persegiPanjang = new segiEmpat (9,5);

        //membuat objek bujur sangkar
        segiEmpat bujurSangkar = new segiEmpat (7);

        //memanggil tampilkanLuas
        persegiPanjang.tampilkanLuas("Luas persegi Panjang adalah = ");
        bujurSangkar.tampilkanLuas  ("Luas bujur sangkar adalah   = ");
        
    }
}