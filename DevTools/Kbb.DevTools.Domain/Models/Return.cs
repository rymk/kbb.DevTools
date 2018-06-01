using System;

namespace Kbb.DevTools.Domain.Models
{
    public class Return
    {
        public int ReturnId { get; set; }
        public int UserId { get; set; }
        public string UserFullname { get; set; } // TODO: should this be here or pulled off Customer?
        public DateTime DateCreated { get; set; }
        public string OrderNumber { get; set; }

        
        // TODO: flesh these out, i copied over from DB...
        public int CustomerUserID { get; set; }
        public int CustomerBillingAddress { get; set; }
        public int CustomerShippingAddress { get; set; }
        public int StatusID { get; set; }
        public int ReturnTemplateID { get; set; }
        public bool Completed { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public User Customer { get; set; }
    }
}
