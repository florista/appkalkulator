using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection 
        static List<Penjualan> daftaraPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Pemrograman_19.11.2919";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Customer();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota    : ");
            penjualan.Nota = Console.ReadLine();
            Console.Write("Tanggal    : ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Nama Customer    : ");
            penjualan.Nama = Console.ReadLine();
			Console.WriteLine("Jenis [T/K] : ");
            string JenisPembayaran = Console.ReadLine();
            penjualan.JenisPembayaran = (JenisPembayaran == "T" || JenisPembayaran == "K") ? "Tunai" : "Kredit";
			Console.Write("Total Nota    : ");
            penjualan.Total_Nota = double.Parse(Console.ReadLine());
            
            daftarPenjualan.Add(penjualan);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus data dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                if (penjualan.Nota == nota)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\nData Penjual berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nNota tidak ditemukan");
            }

            
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjual yang ada di dalam collection
            int noUrut = 0;
            Console.WriteLine("Data Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3}", noUrut, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.JenisPembayaran, penjualan.Total_Nota) ;
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Tidak Ada");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}