using System;

namespace tgs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double KURS;
            int TOTALUSD;
            while (true)
            {
                try
                {
                    Console.Write("Rate USD ke Rp. : ");
                    KURS = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("maaf, angka melebihi kapasitas");
                    continue;
                }
            }
            while (true)
            {
                try
                {
                  Console.Write("jumlah Usd     : ");
                  TOTALUSD = Convert.ToInt32(Console.ReadLine());
                  break;  
                }
                catch (System.Exception)
            {
                Console.WriteLine("maaf. Hanya menerima input berupa angka");
            }
            }
              Console.WriteLine("Hasil konversi : Rp."+(KURS + TOTALUSD));
        }
    }
}              
