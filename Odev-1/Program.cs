using System;
using System.Collections;


namespace odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalolmayan  =new ArrayList();
            int[] sayilar = new int[20];
            int k;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz",(i+1));
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                
                
            }
            
            for (int i = 0; i <10; i++)
            {
                k=0;
                
                for(int j = 2;j<sayilar[i];j++)
                {
                    if(sayilar[i] % j==0)
                    {
                        k=1;
                    } 
                    
                }
                if(k==1) {
                    asalolmayan.Add(sayilar[i]);
                } else {
                    asal.Add(sayilar[i]);
                }

                
            }
            Console.WriteLine("**** Asal ****");
            foreach (var item in asal)
            {
                
                Console.Write(item+" ");
            }
            Console.WriteLine("\n**** Asal Olmayan ****");
            foreach (var item in asalolmayan)
            {
                
                Console.Write(item+" ");
            }

        }
    }
}