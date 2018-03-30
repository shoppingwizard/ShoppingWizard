using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class firmaAdres
    {[Key]
        public int firmaAdresId { get; set; }
        public string adres { get; set; }

        public virtual Firmalar fk_firmadres { get; set; }
    }
}