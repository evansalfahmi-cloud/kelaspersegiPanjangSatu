/*
OVERLOAD TERHADAP METODE
overload adalah proses pendefinisian dua buah metode dengan nama sama tapi parameternya berbeda

CONTOH
*/
using System ;

class persegiPanjang {
    public double panjang;
    public double lebar;

    public persegiPanjang (double p , double l){ //konstruktor persegi Panjang
        panjang = p ; 
        lebar = l;
    }

    private double rumusLuas (){
        return panjang * lebar;
    }

    public void tampilkanLuas (){
        Console.WriteLine("Luas = "+ rumusLuas());
    }

    public void tampilkanLuas(string s){ //overload tampilkanLuas
        Console.WriteLine(s+rumusLuas());
    }
}

class overloadDemoMetode
{
    static void Main (){
        persegiPanjang perPjg  = new persegiPanjang(8,7);

        //memanggil metode rumus luas tanpa parameter
        perPjg.tampilkanLuas();
        
        //memanggil metode rumus luas dengan parameter string s
        perPjg.tampilkanLuas("Luas persegi Panjang adalah = ");
    }
}