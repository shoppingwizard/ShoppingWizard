using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class FirmaGaleri
    {   [Key]
        public int firmaGaleriId { get; set; }
        public string fotoUrl { get; set; }

        public virtual Kategoriler fk_kategorifirmagaleri { get; set; }
    }
}