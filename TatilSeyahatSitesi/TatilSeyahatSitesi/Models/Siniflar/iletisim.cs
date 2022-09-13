using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class iletisim
    {
        [Key]
        public int iletisimId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public string Mail { get; set; }
        public string Baslik { get; set; }
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
    }
}