using System;

namespace Odev_2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] dizi = new int[20];
           for(int i=0;i<dizi.Length;i++)
           {
             dizi[i] = Convert.ToInt32(Console.ReadLine());
             
           }
           Array.Sort(dizi);
           
           Console.WriteLine("En büyük 3 Sayı Sırasıyla : {0}, {1}, {2}",dizi[17],dizi[18],dizi[19]);
            Console.WriteLine("En küçük 3 Sayı Sırasıyla : {0}, {1}, {2}",dizi[0],dizi[1],dizi[2]);

            double buyukOrt = (dizi[17]+dizi[18]+dizi[19])/3;
            double kucukOrt = (dizi[0]+dizi[1]+dizi[2])/3;

           Console.WriteLine("En Buyuk sayıların ortalamsı: "+buyukOrt);
           Console.WriteLine("En Kucuk sayıların ortalamsı :"+kucukOrt);
            int toplamOrt = Convert.ToInt32((buyukOrt+kucukOrt)/2);
           Console.WriteLine("Girdiginiz en buyuk ve en kucuk 3 sayinin ortalamasının toplamı :"+toplamOrt);
        }
    }
}