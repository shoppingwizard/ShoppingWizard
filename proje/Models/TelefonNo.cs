using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class TelefonNo
    {[Key]
        public int telefonnoId { get; set; }
        public string telefonNo { get; set; }

        public virtual Firmalar fk_firmatel { get; set; }
    }
}