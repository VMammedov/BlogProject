using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        public ICollection<Writer> Writers { get; set; }
    }
}
