using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Kereta
    {
        public string Nama { get; set; }
        public abstract double Bayar();
        public abstract double Kembalian();
    }
}
