using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class YorumvePuan
    {[Key]
        public int yorumvepuanId { get; set; }
        public string yorum { get; set; }
        public int puan { get; set; }
        public string yorumFotoUrl { get; set; }


        public virtual Kullanicilar fk_yorumKullanici { get; set; }
        public virtual Firmalar fk_firmayorum { get; set; }
    }
}