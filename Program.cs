using System;
using System.Collections.Generic;


abstract class TiketBioskop
{
   
    private string namaPenonton;
    private string idBooking;
    private string judulFilm;

   
    public string NamaPenonton { get => namaPenonton; set => namaPenonton = value; }
    public string IdBooking { get => idBooking; set => idBooking = value; }
    public string JudulFilm { get => judulFilm; set => judulFilm = value; }


    public TiketBioskop(string nama, string id, string film)
    {
        NamaPenonton = nama;
        IdBooking = id;
        JudulFilm = film;
    }


    public void TampilInfo()
    {
        Console.WriteLine($"Nama: {NamaPenonton} | ID: {IdBooking} | Film: {JudulFilm}");
    }


    public abstract int HitungTotalHarga(int jumlahTiket);
}


class TiketReguler : TiketBioskop
{
    private int hargaTiket;

    public int HargaTiket { get => hargaTiket; set => hargaTiket = value; }

    public TiketReguler(string nama, string id, string film, int harga)
        : base(nama, id, film)
    {
        HargaTiket = harga;
    }

  
    public override int HitungTotalHarga(int jumlahTiket)
    {
        return jumlahTiket * HargaTiket;
    }
}


class TiketPremiere : TiketBioskop
{
    private int hargaTiket;
    private int biayaLounge;

    public int HargaTiket { get => hargaTiket; set => hargaTiket = value; }
    public int BiayaLounge { get => biayaLounge; set => biayaLounge = value; }

    public TiketPremiere(string nama, string id, string film, int harga, int lounge)
        : base(nama, id, film)
    {
        HargaTiket = harga;
        BiayaLounge = lounge;
    }

    
    public override int HitungTotalHarga(int jumlahTiket)
    {
        return (jumlahTiket * HargaTiket) + BiayaLounge;
    }
}


class RiwayatNonton
{
    public string JenisStudio { get; set; }
    public int JumlahTiket { get; set; }
    public string TanggalNonton { get; set; }

    public void CetakRiwayat()
    {
        Console.WriteLine($"{JenisStudio} | {JumlahTiket} tiket | {TanggalNonton}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        TiketPremiere tiket1 = new TiketPremiere("Andi", "BKS02", "Spider-Man", 80000, 10000);
        tiket1.TampilInfo();
        int total = tiket1.HitungTotalHarga(3);
        Console.WriteLine($"Total: Rp {total}");

        RiwayatNonton riwayat = new RiwayatNonton
        {
            JenisStudio = "Premiere",
            JumlahTiket = 3,
            TanggalNonton = "12-10-2025"
        };
        riwayat.CetakRiwayat();
    }
}
