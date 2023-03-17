using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTodoUygulamasi
{
    public class TodoClass
    {
        public Guid Id { get; set; }

        [DisplayName("Başlık")]
        public string Baslik { get; set; }

        [DisplayName("Özet Bilgi")]
        public string OzetBilgi { get; set; }

        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        [DisplayName("Önem Derecesi")]
        public int OnemDerecesi { get; set; }
        public string Durum { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
