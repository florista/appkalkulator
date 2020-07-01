using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> kt = new List<KaryawanTetap>();
            List<KaryawanHarian> kh = new List<KaryawanHarian>();
            List<Sales> s = new List<Sales>();

            int pilihan;
            menu :
            Console.Title = "Tugas Lab 8 (Pertemuan 12) -- Polymorphism, Abstraction & Collection ";
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Tambah Data Karyawan");
            Console.WriteLine();
            Console.Write("2.Tampilkan Data Karyawan");
            Console.WriteLine();
            Console.Write("3.Hapus Data Karyawan");
           
            Console.WriteLine();

            Console.Write("Pilih Nomor berapa (1-4) = ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1 || pilihan == 1)
            {
                Console.WriteLine("1. Karyawan Tetap");
                Console.WriteLine("2. Karyawan Harian");
                Console.WriteLine("3. Sales");
                Console.WriteLine("Pilih : ");
                int pil = int.Parse(Console.ReadLine());
                if (pil == 1 || pil == 1)
                {
                    Console.WriteLine("                      Karyawan Tetap                                ");
                    Console.Write("Nik : ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama : ");
                    string nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    double gajibulanan = Convert.ToDouble(Console.ReadLine());

                    kt.Add(new KaryawanTetap() { Nik = nik, Nama = nama, GajiBulanan=gajibulanan });

                }

                else if (pil == 2 || pil == 2)
                {
                    Console.WriteLine("                      Karyawan Harian                                ");
                    Console.Write("Nik : ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama : ");
                    string nama = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja : ");
                    double jam = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Upah Per Jam : ");
                    double upah = Convert.ToDouble(Console.ReadLine());

                    kh.Add(new KaryawanHarian() { Nik = nik, Nama = nama, UpahPerJam=upah, JumlahJamKerja=jam });
                }

                else if (pil == 3 || pil == 3)
                {
                    Console.WriteLine("                      Sales                                ");
                    Console.Write("Nik : ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama : ");
                    string nama = Console.ReadLine();
                    Console.Write("Jumlah Penjualan : ");
                    double jumlah = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Komisi : ");
                    int komisi = Convert.ToInt16(Console.ReadLine());

                    s.Add(new Sales() { Nik = nik, Nama = nama, JumlahPenjualan=jumlah, Komisi=komisi });

                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;


            }

            else if (pilihan == 2 || pilihan == 2)
            {


                Console.WriteLine("List Data Pegawai");
                int no = 1;
                foreach (Karyawan karyawan in kt)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                foreach (Karyawan karyawan in kh)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                foreach (Karyawan karyawan in s)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }
            
            else if(pilihan == 3 || pilihan == 3)
            {


                Console.WriteLine("Pilihan Hapus Karyawan");
                string hapus;
                Console.WriteLine("Masukan NIK : ");
                hapus = Console.ReadLine();
                int x = 0;
                foreach(Karyawan karyawan in kt)
                {
                    if (hapus == karyawan.Nik)
                    {
                        kt.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in kh)
                {
                    if (hapus == karyawan.Nik)
                    {
                        kh.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in s)
                {
                    if (hapus == karyawan.Nik)
                    {
                        s.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else
            {
                Console.WriteLine("Terimakasih telah menggunakan Aplikasi ini");
            }

                
            Console.ReadKey(true);
            Console.Clear();
            
        }

 
        
    }
}