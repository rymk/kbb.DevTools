using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kbb.DevTools.DAL.Entities
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [MaxLength(500), Required]
        public string AddressLine1 { get; set; }
        [MaxLength(500)]
        public string AddressLine2 { get; set; }
        [MaxLength(500)]
        public string AddressLine3 { get; set; }
        [MaxLength(500), Required]
        public string City { get; set; }
        [Required]
        public int StateID { get; set; } // TODO: FK
        [Required]
        public int CountryID { get; set; } // TODO: FK

        // RELATIONSHIPS
        [ForeignKey("StateID")]
        public States State { get; set; }
        [ForeignKey("CountryID")]
        public Country Country { get; set; }

        // TODO: this is kind of stupid from this direction, in realiity prob want a third (manually defined) list that is all Returns regardless of usage...
        // wont look pretty with scaling, but will definitely work....
        [InverseProperty("BillingAddress")]
        public List<Return> BillingReturns { get; set; }
        [InverseProperty("ShippingAddress")]
        public List<Return> ShippingReturns { get; set; }
    }
}
