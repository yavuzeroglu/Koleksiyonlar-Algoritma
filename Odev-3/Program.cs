using System;

namespace Odev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle="";
            Console.WriteLine("Cumle giriniz :");
            cumle = Console.ReadLine();
            char[] karakter = {'a','e','ı','i','o','ö','u','ü',};
            List<char> List = new List<char>();
            for (int i = 0; i < cumle.Length; i++)
            {
                if(karakter.Contains(Convert.ToChar(cumle.Substring(i,1)))){
                    List.Add(Convert.ToChar(cumle.Substring(i,1)));
                }
            }
            char[] istenenArray = new char[List.Count];
            int j =0;
            foreach (char item in List)
            {
                istenenArray[j] = item;
                j++;
            }
            Console.WriteLine("Cumlede geçen sesli harfler (sırasıyla)");
            foreach(char item in istenenArray){
                Console.WriteLine(item);
            }
            
        }
    }
}