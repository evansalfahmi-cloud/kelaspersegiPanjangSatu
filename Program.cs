/*
MENGEMBALIKAN NILAI BERTIPE OBJEK

selain dapat digunakan sevagai parameter objek juga dapat diperankan sebagai nilai kembalian dari suatu metode
yang dikembalikan adalah referensinya
selanjutnya referensi yang dikembalikan oleh metode tersebut dapat ditampung oleh referensi lain
untuk melakukan hal ini kita perlu membuat objek baru di dalam badan metode

CONTOH
*/
using System;

class persegiPanjang {
    private double panjang ;
    private double lebar;

    //mendefinisikan konstruktor dengan parameter
    //berupa referensi ke objek
    public persegiPanjang (persegiPanjang obj){
        panjang = obj.panjang;
        lebar = obj.lebar;
    }

    //konstruktorparameter
    public persegiPanjang (double p , double l){
        panjang = p;
        lebar = l;
    }

    //rumus menghitung luas
    private double rumusLuas (){
        return panjang * lebar;
    }

    //menampilkan nilai luas
    public void tampilkanLuas (string s){
        Console.WriteLine ("Luas "+s+"\t = "+ rumusLuas());
    }

    //mendefinisikan metode yang mengembalikan objek
    public persegiPanjang perbesarObjek (int perBesaran){
        persegiPanjang obj = new persegiPanjang (panjang * perBesaran , lebar * perBesaran);
        //mengembalikan objek
        return obj;
    }
}

class pengembalianObjek {
    static void Main () {
        persegiPanjang perPjg1, perPjg2;
        perPjg1 = new persegiPanjang (8,7);

        //buat objek baru dengan memanggil metode PerbesaraObjek()
        perPjg2 = perPjg1.perbesarObjek(2); //diperbesar 2 kali dari ukuran semula

        //menampilkan luas 
        Console.WriteLine ("-----------------------");
        Console.WriteLine (" Demo perbesaran objek ");
         Console.WriteLine("-----------------------");
        perPjg1.tampilkanLuas ("objek pertama");
        perPjg2.tampilkanLuas ("objek kedua");

    }
}