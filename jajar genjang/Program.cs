using System; 
class Program 
{ 
 static void Main() 
 { 

 Console.Write("Masukkan nilai alas jajarggenjang: "); 
 int alas = Convert.ToInt32(Console.ReadLine()); 

 Console.Write("Masukkan nilai tinggi jajarggenjang: "); 
 int tinggi = Convert.ToInt32(Console.ReadLine()); 
 
 int hasil = alas *tinggi; 

 Console.WriteLine("Hasil penjumlahan: " + hasil);
 }
}