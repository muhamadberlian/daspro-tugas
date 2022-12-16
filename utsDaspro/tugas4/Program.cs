using System;
using System.Text.RegularExpressions;

namespace tgs4
{
    class Program
    {
        static void Main(string[] args) {
            String teks, enkripsi = "";
            String alfabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Regex RgX = new Regex ("[^A-Za-z ]");
            do
            {
                Console.Write("Text : ");
                teks = Console.ReadLine();
            } 
            while (String.IsNullOrEmpty(teks) || RgX.IsMatch(teks));
            foreach (Char t in teks)
            {
                Char temp = ' ';
                for (int i = 0; i < alfabet.Length; i++)
                {
                    Char c = alfabet[i];
                    if (t.Equals(c)) {
                        temp = alfabet[i+3];
                        break;
                    } else if(t.Equals(' ')) {
                        temp = ' ';
                        break;
                    }
                }
                enkripsi = enkripsi + temp;       
            }
            Console.WriteLine("enkripsi : " + enkripsi);
        }
    }
}
