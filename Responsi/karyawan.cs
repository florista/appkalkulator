using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrogramman2921
{
   public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int No, int Nik, string Nama, int GajiBulanan)
        {
            this.No = No;
            this.Nik = Nik;
            this.Nama = Nama;
            
            if (GajiBulanan<0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
       
        public void Data()
        {
            Console.WriteLine("{0}\t{01}\t {2}\t {3}", No, Nik, Nama, GajiBulanan);           
        }
        public void Naikgaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}\t{1}\t {2}\t {3}", No, Nik, Nama, GajiBulanan);
        }
    }
}