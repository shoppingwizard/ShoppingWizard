using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Kategoriler
    { [Key]
        public int kategoriId { get; set; }
        public string kategoriAdi { get; set; }

       
        public virtual List<Firmalar> fk_firmakategori { get; set; }
        public virtual List<FirmaGaleri> fk_kategorifirmagaleri { get; set; }
    }
}