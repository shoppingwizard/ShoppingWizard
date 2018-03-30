using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Favoriler
    {
        [Key]
        public int favoriId{ get; set; }


        public virtual Kullanicilar fk_kullanicifav { get; set; }
        public virtual Firmalar fk_favfirma { get; set; }
    }
}