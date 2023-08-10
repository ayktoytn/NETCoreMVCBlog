using System;

namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int DogumTarihi { get; set; }
        public int KullaniciCinsiyeti
    }
}
