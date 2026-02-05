using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //1. Askeri Üret (Nesne Yaratma)
        Savasci asker1 = new Savasci(); // new komutu "Yarat" demektir.
        asker1.Isim = "Barbar";
        asker1.Can = 100;
        asker1.HasarGucu = 25; 

        // 2. Askeri Üret
        Savasci asker2 = new Savasci(); 
        asker2.Isim = "Okcu";
        asker2.Can = 80;
        asker2.HasarGucu = 40;

        asker1.BilgiGoster();
        asker2.BilgiGoster();
    }
/*
    static int RastgeleHasarUret(int min, int max)
    {
        Random zar = new Random();
        int value = zar.Next(min, max);
        return value;
    }
    static int KritikVurusYap(int safHasar)
    {
        int sonuc = safHasar * 2;
        return sonuc;
    }
    static void HasarVer(string dusmanAdi, int hasarMik)
    {
        Console.WriteLine(dusmanAdi + " sana saldirdi ve " + hasarMik + " hasar verdi!");
    }
    static void Selamla()
    {
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("----------------------");
    }
    static void BaslangicEkrani()
    {
        Console.WriteLine("gladyator arena, Version: 1.2. Baslamak icin enter'a basiniz.");
        Console.ReadLine();
    }
    static void BitisEkrani()
    {
        Console.WriteLine("Oyun bitti. Thanks for playing! :) (yazilimci: askei)");
    }
    */
}
class Savasci
{
    //Properties
    public string Isim;
    public int Can;
    public int HasarGucu;
    public void BilgiGoster()
    {
        // Kendi içindeki Isim ve Can değişkenlerini doğrudan kullanır.
        Console.WriteLine("Karakter: " + Isim + " | Can: " + Can + " | Hasar Gücü: " + HasarGucu);
    }
}
