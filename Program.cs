using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kereta> listKereta = new List<Kereta>();
            Console.WriteLine("\t TIKET KERETA API");
            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine("\n Nama Kereta Api");
            Console.WriteLine(" 1. Arga Bromo (Surabaya Pasarturi - Jakarta Gambir)");
            Console.WriteLine(" 2. Arga Lawu (Solo Balapan - Jakarta Gambir)");
            Console.WriteLine(" 3. Arga Muria (Semarang Tawang - Jakarta Gambir)");
            Console.Write("\n Pilih Kereta Api : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (pilih)
            {
                case 1:
                    Console.WriteLine("\t TIKET KERETA API");
                    Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                    Console.WriteLine(" ---------------------------------");
                    Console.WriteLine("\t    ARGA BROMO");
                    Console.WriteLine("\n Pilihan Kelas");
                    Console.WriteLine(" 1. Eksekutif");
                    Console.WriteLine(" 2. Bisnis");
                    Console.WriteLine(" 3. Ekonomi");
                    Console.Write("\n Masukkan Kelas : ");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 1:
                            Eksekutif eksekutif = new Eksekutif();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA BROMO");
                            Console.WriteLine("\t    EKSEKUTIF");
                            Console.Write("\n Nama Pemesan           : ");
                            eksekutif.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Bromo");
                            Console.WriteLine(" Tujuan                 : Surabaya Pasarturi - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Eksekutif");
                            eksekutif.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp.150000");
                            eksekutif.HargaTiket = 150000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            eksekutif.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(eksekutif);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            eksekutif.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(eksekutif);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;

                        case 2:
                            Bisnis bisnis = new Bisnis();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA BROMO");
                            Console.WriteLine("\t      BISNIS");
                            Console.Write("\n Nama Pemesan           : ");
                            bisnis.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Bromo");
                            Console.WriteLine(" Tujuan                 : Surabaya Pasarturi - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Bisnis");
                            bisnis.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp100000");
                            bisnis.HargaTiket = 100000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            bisnis.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(bisnis);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            bisnis.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(bisnis);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;
                            
                        case 3:
                            Ekonomi ekonomi = new Ekonomi();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA BROMO");
                            Console.WriteLine("\t     EKONOMI");
                            Console.Write("\n Nama Pemesan           : ");
                            ekonomi.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Bromo");
                            Console.WriteLine(" Tujuan                 : Surabaya Pasarturi - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Ekonomi");
                            ekonomi.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp50000");
                            ekonomi.HargaTiket = 50000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            ekonomi.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(ekonomi);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            ekonomi.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(ekonomi);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("\t TIKET KERETA API");
                    Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                    Console.WriteLine(" ---------------------------------");
                    Console.WriteLine("\t    ARGA LAWU");
                    Console.WriteLine("\n Pilihan Kelas");
                    Console.WriteLine(" 1. Eksekutif");
                    Console.WriteLine(" 2. Bisnis");
                    Console.WriteLine(" 3. Ekonomi");
                    Console.Write("\n Masukkan Kelas : ");
                    int menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu2)
                    {
                        case 1:
                            Eksekutif eksekutif = new Eksekutif();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA LAWU");
                            Console.WriteLine("\t    EKSEKUTIF");
                            Console.Write("\n Nama Pemesan           : ");
                            eksekutif.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Lawu");
                            Console.WriteLine(" Tujuan                 : Solo Balapan - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Eksekutif");
                            eksekutif.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp160000");
                            eksekutif.HargaTiket = 160000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            eksekutif.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(eksekutif);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            eksekutif.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(eksekutif);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;

                        case 2:
                            Bisnis bisnis = new Bisnis();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA LAWU");
                            Console.WriteLine("\t      BISNIS");
                            Console.Write("\n Nama Pemesan           : ");
                            bisnis.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Lawu");
                            Console.WriteLine(" Tujuan                 : Solo Balapan - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Bisnis");
                            bisnis.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp120000");
                            bisnis.HargaTiket = 120000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            bisnis.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(bisnis);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            bisnis.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(bisnis);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;

                        case 3:
                            Ekonomi ekonomi = new Ekonomi();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA LAWU");
                            Console.WriteLine("\t     EKONOMI");
                            Console.Write("\n Nama Pemesan           : ");
                            ekonomi.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Lawu");
                            Console.WriteLine(" Tujuan                 : Solo Balapan - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Ekonomi");
                            ekonomi.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp75000");
                            ekonomi.HargaTiket = 75000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            ekonomi.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(ekonomi);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            ekonomi.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(ekonomi);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("\t TIKET KERETA API");
                    Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                    Console.WriteLine(" ---------------------------------");
                    Console.WriteLine("\t    ARGA MURIA");
                    Console.WriteLine("\n Pilihan Kelas");
                    Console.WriteLine(" 1. Eksekutif");
                    Console.WriteLine(" 2. Bisnis");
                    Console.WriteLine(" 3. Ekonomi");
                    Console.Write("\n Masukkan Kelas : ");
                    int menu3 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu3)
                    {
                        case 1:
                            Eksekutif eksekutif = new Eksekutif();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA MURIA");
                            Console.WriteLine("\t    EKSEKUTIF");
                            Console.Write("\n Nama Pemesan           : ");
                            eksekutif.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Muria");
                            Console.WriteLine(" Tujuan                 : Semarang Tawang - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Eksekutif");
                            eksekutif.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp100000");
                            eksekutif.HargaTiket = 100000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            eksekutif.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(eksekutif);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            eksekutif.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(eksekutif);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;

                        case 2:
                            Bisnis bisnis = new Bisnis();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA MURIA");
                            Console.WriteLine("\t      BISNIS");
                            Console.Write("\n Nama Pemesan           : ");
                            bisnis.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Muria");
                            Console.WriteLine(" Tujuan                 : Semarang Tawang - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Bisnis");
                            bisnis.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp85000");
                            bisnis.HargaTiket = 85000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            bisnis.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(bisnis);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            bisnis.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(bisnis);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;

                        case 3:
                            Ekonomi ekonomi = new Ekonomi();
                            Console.WriteLine("\t TIKET KERETA API");
                            Console.WriteLine(" PT Kereta Api Indonesia (Persero)");
                            Console.WriteLine(" ---------------------------------");
                            Console.WriteLine("\t    ARGA MURIA");
                            Console.WriteLine("\t     EKONOMI");
                            Console.Write("\n Nama Pemesan           : ");
                            ekonomi.Nama = Console.ReadLine();
                            Console.WriteLine(" Nama Kereta            : Arga Muria");
                            Console.WriteLine(" Tujuan                 : Semarang Tawang - Jakarta Gambir");
                            Console.WriteLine(" Kelas Kereta           : Ekonomi");
                            ekonomi.spesifikasi();
                            Console.WriteLine("\n Harga Tiket            : Rp40000");
                            ekonomi.HargaTiket = 40000;
                            Console.Write(" Jumlah Pemesanan Tiket : ");
                            ekonomi.JumlahTiket = Convert.ToDouble(Console.ReadLine());
                            listKereta.Add(ekonomi);
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", kereta.Bayar());
                            }
                            Console.Write(" Uang Pembayaran        : Rp.");
                            ekonomi.UangBayar = Convert.ToDouble(Console.ReadLine());
                            foreach (Kereta kereta in listKereta)
                            {
                                Console.WriteLine(" Uang Kembalian         : Rp.{0}", kereta.Kembalian());
                            }
                            listKereta.Add(ekonomi);
                            Console.WriteLine("\n Terimakasih sudah melakukan pembelian tiket Kereta Api Indonesia");
                            Console.WriteLine(" Semoga perjalanan Anda selamat sampai tujuan");
                            break;
                    }
                    break;
            }

        Console.ReadKey();
        }
    }
}