using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kbb.DevTools.DAL.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(255), Required]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string MiddleName { get; set; }
        [MaxLength(255), Required]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [MaxLength(500), Required]
        public string Email { get; set; }
        [MaxLength(255), Required]
        public string UserName { get; set; }
        [MaxLength(255), Required]
        public string Password { get; set; } // TODO: so many things wrong with this... do correctly, minimally encode and increase col max

        public List<Return> Returns { get; set; }
    }
}
