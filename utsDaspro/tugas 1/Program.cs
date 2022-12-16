using System;

public class NameTag
{
    public static void Main(string[] args)
    {
        string nama;
        string nim;
        string konsentrasi;

		Console.Write("Nama : ");
		nama = Console.ReadLine();
		Console.Write("Nim : ");
		nim = Console.ReadLine();
		Console.Write("Konsentrasi : ");
		konsentrasi = Console.ReadLine();
		
		Console.WriteLine("| ******************** |");
        Console.WriteLine("| Nama:          {0} |", nama);
		Console.WriteLine("|               {0} |", nim);
		Console.WriteLine("| -------------------- |");
		Console.WriteLine("|                  {0} |", konsentrasi);
		Console.WriteLine("| ******************** |");
    }
}  