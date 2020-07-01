using System;
using Collection.induk;
namespace Collection.anak

{
public class Sales : Karyawan
    {
        public override string Nama {get; set;}
        public override string Nik {get; set;}
        public double JumlahPenjualan{get; set;}
        public int Komisi{get; set;}
        public override double TotalGaji()
        {
            return JumlahPenjualan * Komisi;
            
        }
            
    }
}
