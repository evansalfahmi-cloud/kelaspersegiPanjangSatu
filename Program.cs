/*

mengisi nilai pada referensi
menyalin referensi dari sebuah objek ke objek lainnya


*/

using System;

//pendefinisian kelas persegiPanjang
class persegiPanjang {
    public double panjang;
    public double lebar;

}

//memembuat kelas main program
class DemoKelasReference
{
    static void Main(){
        // membuat variabel baru untuk memuat hasil perkalian panjang * lebar 
        //inisiasi bernama luas
        persegiPanjang persegiPanjang1, persegiPanjang2 ;
        persegiPanjang1 = new persegiPanjang();
        persegiPanjang2 = persegiPanjang1;

        //mengisi niai ke dalam objek yang ditunjuk oleh persegi panjang1;

        persegiPanjang1.panjang = 12;
        persegiPanjang2.lebar = 21;

        Console.WriteLine ("kondisi awal : \n");
        //menampilkan datadari objek yg ditunjuk oleh persegipanjang1
        Console.WriteLine("persegiPanjang1");
        Console.WriteLine("panjang : "+persegiPanjang1.panjang);
        Console.WriteLine("lebar   : "+persegiPanjang1.lebar);


        //menampilkan data dari objek persegiPanjang2
        Console.WriteLine("persegiPanjang2");
        Console.WriteLine("panjang : "+persegiPanjang2.panjang);
        Console.WriteLine("lebar   : "+persegiPanjang2.lebar);

        //merubah data dalam objek
        persegiPanjang1.panjang = 13;
        persegiPanjang1.lebar = 25;

        Console.WriteLine ("\nkeadaan akhir : \n");

        //menampilkan datadari objek yg ditunjuk oleh persegipanjang1
        Console.WriteLine("persegiPanjang1");
        Console.WriteLine("panjang : "+persegiPanjang1.panjang);
        Console.WriteLine("lebar   : "+persegiPanjang1.lebar);


        //menampilkan data dari objek persegiPanjang2
        Console.WriteLine("persegiPanjang2");
        Console.WriteLine("panjang : "+persegiPanjang2.panjang);
        Console.WriteLine("lebar   : "+persegiPanjang2.lebar);
    }
}

