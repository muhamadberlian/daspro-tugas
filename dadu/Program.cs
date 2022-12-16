using System;
namespace dadu
{
    class dadu
    {
        static int nilaikomputer, skoranda, skorkomputer, ronde, angkadadu, nilaianda;
        static bool mulai;
        static void Main(string[] args)
        {
            
            Init(); 
            pembukaan();
            while(ronde <= 10)
            {
                mulai = true;
                ronde++;
                if(ronde <= 10)
                {
                    mulaigame(); 
                    Console.WriteLine("\npencet enter untuk lanjut"); 
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    showend();
                }
                
           
            }
            Console.WriteLine("\npencet enter untuk keluar"); Console.Clear();
            Console.ReadKey();
        static void pembukaan()
        {
            Console.WriteLine("TEBAK DADU\anda lawan komputer akan melakukan permainan 10 ronde\anda dan komputer akan saling melempar dadu\yang mendapat angka tertiggi akan menjadi pemenangnya\npermainan dimulai");
        }

        static void Init()
        {
            
            ronde = 0;
            skoranda = 0;
            skorkomputer = 0;
        }

        static bool mulaigame()
        {
            Random rng = new Random ();
            nilaikomputer = rng.Next (1,7);
            nilaianda = rng.Next(1,7);

            Console.WriteLine ("saat ini anda berada di ronde "+ronde);
            Console.WriteLine ("Angka anda : "+nilaianda);
            Console.WriteLine ("Angka Komputer : "+nilaikomputer);
            if(nilaianda > nilaikomputer)
            {
                skoranda++;
                Console.WriteLine("skor anda ="+skoranda+"\nskor komputer ="+skorkomputer);
                return true;
            } else if (nilaikomputer > nilaianda)
            {
                skorkomputer++;
                Console.WriteLine("skor anda ="+skoranda+"\nskor komputer ="+skorkomputer);
                return false;
            }else
            {
                Console.WriteLine("ronde ini imbang...");
                return false;
            }
        }
        

        static void showend()
        {
            if(skoranda > skorkomputer)
            {
                Console.WriteLine("selamat! anda menang");Console.ReadLine();
            } else if (skorkomputer > skoranda)
            {
                Console.WriteLine("maaf! anda kalah, coba lagi");Console.ReadLine();
            }else
            {
                Console.WriteLine("hasilnya seri!");Console.ReadLine();
            }
        }
    }
}
}