using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim gelistirici yetistirme kampi";
            string kurs2 = "programlamaya baslangic icin temel kurs";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi", "programlamaya baslangic icin temel kurs","java","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            //foreach dongusu tek tek dolasmaya yariyor. her bi elemana da kurs demis oluyoruz.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
