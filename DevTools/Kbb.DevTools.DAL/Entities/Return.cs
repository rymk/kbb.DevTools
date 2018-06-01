using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kbb.DevTools.DAL.Entities
{
    [Table("Return")]
    public class Return
    {
        [Key]
        public int ReturnID { get; set; }
        public int ClientOrderID { get; set; } // TODO: FK relationship
        [MaxLength(500), Required]
        public string OrderNumber { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public int CustomerUserID { get; set; } // TODO: User object
        [Required]
        public int CustomerBillingAddress { get; set; } // TODO: rename to have ID at end?
        [Required]
        public int CustomerShippingAddress { get; set; } // TODO: rename to have ID at end?
        [Required]
        public int StatusID { get; set; }// TODO: FK
        [Required]
        public int ReturnTemplateID { get; set; }
        [Required]
        public bool Completed { get; set; }

        
        /// RELATIONSHIPS
        [ForeignKey("CustomerBillingAddress")]
        public Address BillingAddress { get; set; }
        [ForeignKey("CustomerShippingAddress")]
        public Address ShippingAddress { get; set; }
        [ForeignKey("CustomerUserID")]
        public User Customer { get; set; }
    }
}
