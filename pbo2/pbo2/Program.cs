using System.Diagnostics.Contracts;

namespace pbo_2
{
    public class sedan
    {
        public String Merkmobil;
        public String Tipemobil;
        public String Warnamobil;
        public int CC;
        public int Kecepatan;

        public sedan(String Merkmobil, String Tipemobil, String Warnamobil, int CC, int Kecepatan)
        {
            this.Merkmobil = Merkmobil;
            this.Tipemobil = Tipemobil;
            this.Warnamobil = Warnamobil;
            this.CC = CC;
            this.Kecepatan = Kecepatan;
        }
        public void Majumundur()
        {
            Console.WriteLine("Merk Mobil       : " + this.Merkmobil);
            Console.WriteLine("Tipe Mobil       : " + this.Tipemobil);
            Console.WriteLine("Warna Mobil      : " + this.Warnamobil);
            Console.WriteLine("Mesin            : " + this.CC + "cc");
            Console.WriteLine("Top Speed        : " + this.Kecepatan + "km/j");
        }
    }

    public class ikan
    {
        public String Namaikan;
        public String Jenisikan;
        public String Habitatikan;
        public String Warnaikan;

        public ikan(String Namaikan, String Jenisikan, String Habitatikan, String Warnaikan)
        {
            this.Namaikan = Namaikan;
            this.Jenisikan = Jenisikan;
            this.Habitatikan = Habitatikan;
            this.Warnaikan = Warnaikan;
        }

        public void Berenang()
        {
            Console.WriteLine("Nama ikan        : " + this.Namaikan);
            Console.WriteLine("Jenis ikan       : " + this.Jenisikan);
            Console.WriteLine("Habitat ikan     : " + this.Habitatikan);
            Console.WriteLine("Warna ikan       : " + this.Warnaikan);
        }
    }
    public class PionCatur
    {
        public String name;
        public String gerakan;
        public String warna2;

        public PionCatur(String name, String gerakan, String warna2)
        {
            this.name = name; 
            this.gerakan = gerakan; 
            this.warna2 = warna2;

        }

        public void langkah()
        {
            Console.WriteLine("Nama     : " + this.name);
            Console.WriteLine("Gerakan  : " + this.gerakan);
            Console.WriteLine("Warna    : " + this.warna2);
        }
    }
    public class RekBank
    {
        public String nama;
        public int noRek;
        public int saldo;

        public RekBank(String nama, int noRek, int saldo)
        {
            this.nama = nama;
            this.noRek = noRek;
            this.saldo = saldo;
        }

        public void Nasabah()
        {
            Console.WriteLine("Nasabah          : " + this.nama);
            Console.WriteLine("No.Rekening      : " + this.noRek);
            Console.WriteLine("Jumlah Tabungan  : Rp. " + this.saldo + ",00");
        }
    }
}
