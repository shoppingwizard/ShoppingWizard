using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Firmalar
    {[Key]
        public int firmaId { get; set; }
        public string firmaAdi { get; set; }
        public string aciklama { get; set; }
        public string email { get; set; }

    
        public virtual List<YorumvePuan> fk_firmayorum { get; set; }
        [ForeignKey("fk_firmakategori")]
        public int KategoriId { get; set; }

        [ForeignKey("fk_kullanicifirma")]
    
        public int kullaniciId { get; set; }

        public virtual Kullanicilar fk_kullanicifirma { get; set; }
        public virtual Kategoriler fk_firmakategori { get; set; }

        public virtual List<Favoriler> fk_favfirma { get; set; }

        public virtual List<firmaAdres> fk_firmadres { get; set; }

        public virtual List<TelefonNo> fk_firmatel { get; set; }
    }
}