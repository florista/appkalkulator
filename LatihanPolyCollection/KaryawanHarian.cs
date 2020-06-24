using System;
using Collection.induk;
namespace Collection.anak
{

    public class KaryawanHarian : Karyawan
    {
        public override string Nama{get; set;}
        public override string Nik {get; set;}
        
        public double JumlahJamKerja {get; set;}
        public double UpahPerJam {get; set;}

        public override double TotalGaji()
        {
            return JumlahJamKerja*UpahPerJam;
    }

    }
}





           
    
