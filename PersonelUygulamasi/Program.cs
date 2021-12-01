using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            //Helper H1 = new Helper();

            P1.Isim = "faik";
            P1.Soyisim = "Turan";
            P1.EmailAdres = "faik.turan";
            P1.Cinsiyet = 717770001;


            Personel P2 = new Personel();

            P2.Isim = "ali";
            P2.Soyisim = "gel";
            P2.EmailAdres = "ali.gel";
            P2.Cinsiyet = 717770002;

            Helper.emailGonder("ik@Firmam.com", "Yeni Personel Bilgilendirme", P1.Isim+ P1.Soyisim);
            Helper.emailGonder("ik@Firmam.com", "Yeni Personel Bilgilendirme", P2.Isim+ P2.Soyisim);
            Console.ReadKey();

        }
    }
}
