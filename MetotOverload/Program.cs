using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverload
{
    class Program
    {
        //Aynı isimde bir metodun birden fazla şekilde tanımlama yapılması
        //Örneğin Console.WriteLine metodu overload şeklindedir. Birden fazla şekilde kullanılması tanımlanmıştır. Metodun imzası farklıdır. Yani public static void Write(decimal value) imzasıdır.

        //
        static void Main(string[] args)
        {
            OrtalamayiBul(12, 14);

            Console.ReadLine();
        }

        //MetotOverload Özeti
        /// <summary>
        /// 2 double sayının aritmetik ortalamasını hesaplar ve double olarak sonucu size verir
        /// </summary>
        /// <param name="sayi1">double tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi2">double tipte bir sayı girmelisiniz.</param>
        /// <returns>double sonuç döndürür.</returns>
        private static double OrtalamayiBul(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }

        /// <summary>
        /// 2 integer sayının aritmetik ortalamasını hesaplar ve double olarak sonucu size verir
        /// </summary>
        /// <param name="sayi1">integer tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi2">integer tipte bir sayı girmelisiniz.</param>
        /// <returns>integer sonuç döndürür.</returns>
        private static int OrtalamayiBul(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }

        /// <summary>
        /// 2 decimal sayının aritmetik ortalamasını hesaplar ve double olarak sonucu size verir
        /// </summary>
        /// <param name="sayi1">decimal tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi2">decimal tipte bir sayı girmelisiniz.</param>
        /// <returns>decimal sonuç döndürür.</returns>
        private static void OrtalamayiBul(decimal sayi1, decimal sayi2)
        {
            Console.WriteLine("Ortalama: " + (sayi1 + sayi2) / 2);
        }
        /// <summary>
        /// 3 double sayının aritmetik ortalamasını hesaplar ve double olarak sonucu size verir
        /// </summary>
        /// <param name="sayi1">double tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi2">double tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi3">double tipte bir sayı girmelisiniz.</param>
        /// <returns></returns>
        private static double OrtalamayiBul(double sayi1, double sayi2, double sayi3)
        {
            return (sayi1 + sayi2 + sayi3) / 3;

        }

        /// <summary>
        /// Belirsiz sayıda aldığı double sayınınaritmetik ortalamasını hesaplar ve double olarak sonucu size verir
        /// </summary>
        /// <param name="sayi1">double tipte bir sayı girmelisiniz.</param>
        /// <param name="sayi2">double tipte bir sayı girmelisiniz.</param>
        /// <returns>double sonuç döndürür.</returns>
        private static string OrtalamayiBul(params double[] sayilar)
        {
            double toplam = 0, ortalama = 0;
            foreach (double item in sayilar)
            {
                toplam += item;
            }
            ortalama = toplam / sayilar.Length;
            return "Ortalama" + ortalama;
        }
    }
}
