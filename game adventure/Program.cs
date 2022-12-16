using System;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Selamat Datang Di Game Adventure ");
            Console.WriteLine(" Siapa Namamu? ");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+", Siap untuk memulai game?[y/n]");
            string bReady = Console.ReadLine();
            if(bReady == "y")
            {
                Console.WriteLine(player.Name+" Memasuki game...");
                Enemy enemy1 = new Enemy("Monster");
                Console.WriteLine(player.Name+" Bertemu "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" Menyerangmu...");
                Console.WriteLine("Pilih Aksi mu...");
                Console.WriteLine("1. Serang Normal");
                Console.WriteLine("2. Serang Putaran");
                Console.WriteLine("3. Bertahan");
                Console.WriteLine("4. Lari");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        Console.WriteLine(player.Name+" Melakukan Serangan");
                        enemy1.GetHit(player.AttackPower);
                        player.Experienc += 0.8f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.Write("Darah Pemain : "+player.Health+" | Darah Musuh : "+enemy1.Health+"\n");
                        break;
                        case "2" :
                        player.Swing();
                        player.Experienc += 0.8f;
                        enemy1.GetHit(player.AttackPower);
                        Console.Write("Darah Pemain : "+player.Health+" | Darah Musuh : "+enemy1.Health+"\n");
                        break; 
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energi Telah Pulih... ");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" Melarikan Diri...");
                        break;
                    }
                    continue;
                }
                
                Console.WriteLine(player.Name+" Mendapatkan "+player.Experienc+" Exp.");
            }
            else
            {
                Console.WriteLine("Byeee.."); 
                Console.Read();
            }
        }
    }

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experienc { get; set; }
        Random rnd = new Random();

        public Novice(){
            Health = 135;
            SkillSlot = 1;
            AttackPower = 1;
            IsDead = false;
            Experienc = 0f;
            Name = "Newbie";
        }

        public void Swing(){
            if(SkillSlot > 0){
                Console.WriteLine("Serang!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }else{
                Console.WriteLine("Kamu tidak ada energi lagi!");
            }
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" Terserang "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine("Kamu Telah Mati. Game Over!");
            IsDead = true;
        }      
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 75;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }
        
        public void GetHit(int hitValue){
            Console.WriteLine(Name+" Terserang "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine(Name +" Telah Mati");
            IsDead = true;
        }
    }
}