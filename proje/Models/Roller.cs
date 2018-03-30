using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Roller
    {
        [Key]
        public int rolId { get; set; }
        public string rolStatu { get; set; }
        public string rolAciklama{ get; set; }
        
       


        public virtual List<Kullanicilar> fk_rolKullanici { get; set; }

    }
}