using System;

namespace tgs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string NAMA;
            int TahunLahir = 0;

            Console.Write("NAMA          : ");
            NAMA = Console.ReadLine().ToUpper();

            while (true)
            {
                try
                {
                    while (TahunLahir <= 0 || TahunLahir >= 2022)
                    {
                        Console.Write("Tahun Kelahiran : ");
                        TahunLahir = Convert.ToInt32(Console.ReadLine());
                        if (TahunLahir <= 0 || TahunLahir >= 2022)
                        {
                            Console.WriteLine("Tahun lahir tidak sesuai");
                        }
                    }
                    break;
                }
            catch (System.Exception)
            {
                Console.WriteLine("maaf, tidak sesuai");
            }
        }

           printTiket(NAMA, TahunLahir);
        }
        static int biayaTiket(int TahunLahir)
        {
            int umur = 2022 - TahunLahir;
            int biaya = 0;
            if (umur < 10 || umur > 60)
            {
                biaya = 10000;
            }
            else
            {
                biaya = 25000;
            }
            return biaya;
        }
        static void printTiket(string NAMA, int TahunLahir)
        {    
            Console.WriteLine("Terimakasih, ambil tiket anda...\n");
            Console.WriteLine("|**************************|");
            Console.WriteLine("|       --studio 1--       |");
            Console.WriteLine("|NAMA  : {0,18}|",NAMA);
            Console.WriteLine("|Harga : Rp. {0,14}|",biayaTiket(TahunLahir));
            Console.WriteLine("|**************************|");    
        }
    }    
}    
