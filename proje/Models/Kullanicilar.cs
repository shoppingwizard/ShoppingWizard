using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Kullanicilar
    {   [Key]
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string ad{ get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        public string sifre { get; set; }

        public virtual Roller fk_rolKullanici { get; set; }

        public virtual List<YorumvePuan> fk_yorumKullanici { get; set; }
        public virtual List<Favoriler> fk_kullanicifav { get; set; }

        public virtual List<Firmalar> fk_kullanicifirma { get; set; }



    }
}