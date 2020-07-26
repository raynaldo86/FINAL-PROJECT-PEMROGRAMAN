using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Ekonomi : Kereta
    {
        public void spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : AC");
            Console.WriteLine("                          Susunan kursi Penumpang 2-2");
            Console.WriteLine("                          Susunan kursi Penumpang 3-3");
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
