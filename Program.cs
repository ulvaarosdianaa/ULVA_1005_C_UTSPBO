
using System;

namespace BioskopOOPCinema
{
    public class TiketBioskop
    {
        public string namaPenonton { get; set; }
        public int idBooking { get; set; }
        public string judulFilm { get; set; }

        public virtual double HitungTotalHarga()
        {
            return 0; 
        }

        public virtual void TampilkanInfo()
        {
            Console.WriteLine($"Nama Penonton: {namaPenonton}, id Booking: {idBooking}, judul Film: {judulFilm}");
        }
    }

    
    public class TiketReguler : TiketBioskop
    {
        public double hargaTiket { get; set; }
  
        public override double HitungTotalHarga()
        {
            return (jumlahTiket * hargaTiket);
        }

        public override void TampilkanInfo()
        {
            base.TampilkanInfo();
            Console.WriteLine($"Harga Tiket: {hargaTiket}");
        }
    }
    public class TiketPremiere : TiketBioskop
    {
        public double hargaTiket { get; set; }
        public double biayaLounge { get; set; }

        public override double hitungTotalHarga()
        {
            return (jumlahTiket * hargaTiket) + (biayaLounge);
        }

        public override void TampilkanInfo()
        {
            base.TampilkanInfo();
            Console.WriteLine($"Harga Tiket: {hargaTiket}, Biaya Lounge: {biayaLounge}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TiketPremiere[] daftarPenonton = new Penonton[3];

            daftarPenonton[0] = new Penonton
            {
                namaPenonton = "Andi",
                idBooking = "BKS02",
                jumlahTiket = 3,
                hargaTiket = 250000,
                
            };

            foreach (var Penonton in daftarPenonton)
            {
                Penonton.TampilkanInfo();
                Console.WriteLine($"Total: {Penonton.hitungTotalHarga()}");
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadLine();
        }
    }
}

