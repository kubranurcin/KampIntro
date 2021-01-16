using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guvenligi
            //Do not repeat yourself - kendini tekrarlama benimle oynama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis buton goster");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artis butonu goster");
            }
            else
            {
                Console.WriteLine("degismedi butonu goster");
            }

            if (sistemeGirisYapmisMi==true) 
            {
                Console.WriteLine("Kullanici ayarlari butonu");              
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
