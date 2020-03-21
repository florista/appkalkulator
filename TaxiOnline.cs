using System;

namespace Tugas
{   
    public class Program
    {   
        
        public class taxi{

        
        public string DriverName = "Kang Anom";
        public Boolean onDuty = false;
        public int NumPassenger = 4;

         
        public void TaxiInfo(){
            Console.WriteLine("Hai, Nama Saya " + this.DriverName + " Saya Adalah Supir Taxi Yang Akan Mengangkut " + this.NumPassenger + " Orang Penumpang, Selamat Menikmati Perjalanan kak.\n");
        }
        public void PickUpPassenger(){
            Console.WriteLine("Hai, Aku Sekarang Sedang Menjemput " + this.NumPassenger + " Orang Penumpang !\n");
        }
        public void DropOffPassenger(){
            Console.WriteLine("Hai, Aku Sekarang Sedang Menurunkan " + this.NumPassenger + " Orang Penumpang !\n");
        }
    }
        static void Main(string[] args)
        {

            
            taxi Taksilama = new taxi();

            
            Taksilama.TaxiInfo();
            Taksilama.PickUpPassenger();
            Taksilama.DropOffPassenger();
            Console.WriteLine("Objek Kedua, Setelah Value Property Kita Ubah \n");

            
            taxi Gotaxi = new taxi();

            
            Gotaxi.DriverName = "Prada Veron";
            Gotaxi.onDuty = true;
            Gotaxi.NumPassenger = 1;

            //panggil fungsi objek
            Gotaxi.TaxiInfo();
            Gotaxi.PickUpPassenger();
            Gotaxi.DropOffPassenger();

        }
    }
}