using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{


    /// <summary>
    ///  statik olan classlar içinde kapsülleme yapılamaz,static olmayan field tanımları yapılamaz
    ///  
    /// </summary>
    public class Helper
    {
       public static void emailGonder(string aliciEmail,string konu,string icerik)
        {
            Console.WriteLine("Mail gönderme işlemleri başarılı");
        }
       
    }
}
