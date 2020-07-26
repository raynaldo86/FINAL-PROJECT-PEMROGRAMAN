using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Eksekutif : Kereta
    {
        public void spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : AC");
            Console.WriteLine("                          Tirai");
            Console.WriteLine("                          Bantal & Selimut");
            Console.WriteLine("                          Susunan kursi Penumpang 2-2");
            Console.WriteLine("                          Kursi Penumpang bisa direbahkan");
            Console.WriteLine("                          Penumpang yang tidak memiliki tiket tidak boleh menaiki kereta api");
        }
        public double JumlahTiket { get; set; }
        public double HargaTiket { get; set; }
        public double UangBayar { get; set; }
        public override double Bayar()
        {
            return JumlahTiket * HargaTiket;
        }
        public override double Kembalian()
        {
            return UangBayar - Bayar();
        }
    }
}
