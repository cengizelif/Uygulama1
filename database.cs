using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTodoUygulamasi
{
    public static class database
    {
        public static List<kullanici> kullanicilar = new List<kullanici>();
        public static List<TodoClass> todoList = new List<TodoClass>();

        static database()
        {
            //kullanici k = new kullanici();
            //k.Id=Guid.NewGuid();
            //k.KullaniciAd = "";
            //k.Sifre = "";
            //kullanicilar.Add(k);

            kullanicilar.Add(new kullanici() { Id=Guid.NewGuid(), KullaniciAd="admin",Sifre="admin" });    
        }

        public static int KayitEkle(TodoClass item)
        {
            try
            {
                todoList.Add(item);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }
    }
}
