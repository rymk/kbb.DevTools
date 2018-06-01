using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kbb.DevTools.DAL.Entities
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        [MaxLength(5), Required]
        public string CountryAbbrev { get; set; }
        [MaxLength(500), Required]
        public string CountryName { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
