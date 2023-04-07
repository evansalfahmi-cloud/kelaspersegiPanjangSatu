/*
parameter berupa objek juga bisa digunakan pada konstruktor
CONTOH
*/
using System;

class persegiPanjang {
    public double panjang;
    public double lebar;

    //mendefinisikan kosntruktor dg parameter berupa referensi ke objek
    public persegiPanjang (persegiPanjang obj){
        panjang = obj.panjang;
        lebar = obj.lebar;
    }

    //konstruktor persegipanjang untuk memuat data p dan l
    public persegiPanjang (double p , double l){
        panjang = p;
        lebar = l;
    }

    private double rumusLuas(){
        return panjang * lebar;
    }

    public void tampilkanLuas(){
        Console.WriteLine("Luas = "+ rumusLuas());
    }

    //mendefinisikan metode dengan parameter berupa referensi ke objek
    public bool Sama (persegiPanjang obj){
        if (obj.panjang == panjang && obj.lebar == lebar){
            return true ; 
        } else {
            return false;
        }
    }
}

class demoParameterObjekUntukKonstruktor 
{
    static void Main(){
        persegiPanjang perPjg1, perPjg2, perPjg3;
        bool hasil1, hasil2;

        perPjg1 = new persegiPanjang (8,6);
        perPjg2 = new persegiPanjang (10,5);

        //membuat objek yang datanya diambil dari objek lain
        perPjg3 = new persegiPanjang(perPjg1);

        //membandingkan objek yang ditunjuk oleh perPjg1 dan perPjg2
        hasil1 = perPjg1.Sama(perPjg2);

        if (hasil1){
            Console.WriteLine ("perPjg1 sama dengan perPjg2");
        }else {
            Console.WriteLine("perPjg1 tidak sama dengan perPjg2");
        }

        //membandingkan objek yang ditunjuk oleh perPjg1 dan perPjg3;
        hasil2 = perPjg1.Sama(perPjg3);

        if (hasil2){
            Console.WriteLine("perPjg1 sama dengan perPjg3");
        }else {
            Console.WriteLine("perPjg1 tidak sama dengan perPjg3");
        }
    }
}