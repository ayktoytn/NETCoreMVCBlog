using System;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        public int GonderiId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public string GonderiSahibi { get; set; }
    }
}
