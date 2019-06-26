using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Variables
            string fullName = "Rio Adhi Pratama";
            DateTime birthDate = new DateTime(1998, 5, 11);
            Console.WriteLine($"Hai, Pak {fullName}");

            #region SPLIT STRING
            //string[] names = fullName.Split(' ');
            //Console.WriteLine(names[0]); 
            #endregion

            #region SUBSTRING
            //string nickName, middleName, lastName;
            //nickName = fullName.Substring(0, 3);
            //middleName = fullName.Substring(4, 4);
            //lastName = fullName.Substring(9, 7);
            //Console.WriteLine(lastName); 
            #endregion
            #endregion

            #region Number Variables
            int age = DateTime.Now.Year - birthDate.Year;
            Console.WriteLine($"Usia anda {age} tahun");

            #region INTEGER
            //int angka1, angka2, hasil;
            //Console.Write("Masukkan angka ke-1 = ");
            //angka1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Masukkan angka ke-2 = ");
            //angka2 = Convert.ToInt32(Console.ReadLine());
            //hasil = angka1 + angka2;
            ////hasil = angka1 - angka2;
            ////hasil = angka1 * angka2;
            ////hasil = angka1 / angka2;

            //Console.WriteLine($"Hasil = {hasil}"); 
            #endregion

            #region DOUBLE
            //double x = 2.1,
            //           y = 2.2,
            //           z;
            //z = x + y;
            //Console.WriteLine($"Hasil {x} + {y} = {z}"); 
            #endregion

            #region DECIMAL
            //decimal saldo = 10000M, setor = 500M;
            //Console.WriteLine($"Saldo awal = {saldo:C}");
            //saldo = saldo + setor;
            //Console.WriteLine($"Saldo setelah penyetoran = {saldo:C}"); //Rp.1.000
            //Console.WriteLine($"Saldo setelah penyetoran = Rp.{saldo:N}"); //Rp.1.000,00
            //Console.WriteLine($"Saldo setelah penyetoran = {saldo:F}"); //1000,00

            //decimal tarik = 2000M;
            //saldo = saldo - tarik;
            //Console.WriteLine($"Saldo setelah penarikan = Rp.{saldo:N}"); 
            #endregion
            #endregion

            #region Conditional Statements / Branches

            #region IF STATEMENT
            //Console.Write($"Berapa usia anda ? ");
            //int usia = Convert.ToInt32(Console.ReadLine());
            //string kategoriUsia = null;
            //if (usia < 5)
            //{
            //    kategoriUsia = "Balita";
            //}
            //else if (usia >= 5 && usia <= 11)
            //{
            //    kategoriUsia = "Kanak-kanak";
            //}
            //else if (usia >= 12 && usia <= 25)
            //{
            //    kategoriUsia = "Remaja";
            //}
            //else if (usia >= 26 && usia <= 45)
            //{
            //    kategoriUsia = "Dewasa";
            //}
            //else if (usia >= 46 && usia <= 65)
            //{
            //    kategoriUsia = "Lansia";
            //}
            //else if (usia > 65)
            //{
            //    kategoriUsia = "Manula";
            //}
            //else
            //{
            //    kategoriUsia = "Usia Tidak Ditemukan";
            //}

            //Console.WriteLine($"Anda masuk kategori {kategoriUsia}");
            #endregion

            #region SWITCH - CASE
            //Console.Write($"Sudahkah anda makan hari ini (y/n) ? ");
            //string input = Console.ReadLine().ToLower();
            //string pesan = null;
            //switch (input)
            //{
            //    case "y":
            //        pesan = "Baik, semangat bekerja!";
            //        break;
            //    case "n":
            //        pesan = "Segera ke kantin!";
            //        break;
            //    default:
            //        pesan = "Anda tidak jelas";
            //        break;
            //}

            //Console.WriteLine(pesan); 
            #endregion

            #endregion

            #region Collections and Loops
            #region ARRAY OF INTEGER
            //int[] ukuranSepatu = new int[] { 40, 41, 42, 43, 44 };
            #region FOR LOOPS
            //Console.WriteLine("Ukuran sepatu(s) : ");
            //for (int i = 0; i < ukuranSepatu.Length; i++)
            //{
            //    Console.WriteLine(ukuranSepatu[i]);
            //}
            #endregion
            #endregion

            #region ARRAY OF STRING
            //string[] ukuranBaju = new string[] { "XXXL", "XS", "L", "S", "M", "XL", "XXS" };
            #region DO AND WHILE LOOPS
            //int j = 0;
            //do
            //{
            //    Console.WriteLine(ukuranBaju[j]);
            //    j++;
            //} while (j < ukuranBaju.Length);  
            #endregion

            #region WHILE
            //int i = 0;
            //while (i < ukuranBaju.Length)
            //{
            //    Console.WriteLine(ukuranBaju[i]);
            //    i++;
            //}
            #endregion
            #endregion

            #region LIST using System.Collections.Generic;
            //Console.WriteLine("Merk notebook : ");
            //List<string> merkNotebook = new List<string>()
            //{
            //     "HP","Lenovo","Apple Macbook",
            //     "ASUS", "Acer"
            //};

            //merkNotebook.Sort();

            //foreach (var merk in merkNotebook)
            //{
            //    Console.WriteLine(merk);
            //}
            #endregion
            #endregion

            Console.ReadLine();
        }
    }
}
