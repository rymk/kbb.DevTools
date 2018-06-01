using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kbb.DevTools.DAL.Entities
{
    [Table("States")]
    public class States // TODO: rename throughout stack to be singular... will match rest of tbls
    {
        [Key]
        public int StateID { get; set; }
        [MaxLength(5), Required]
        public string StateAbbrev { get; set; }
        [MaxLength(255), Required]
        public string StateName { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
