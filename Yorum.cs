using System;

namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}
