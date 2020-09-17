using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeOrganizerAPI.Model
{
    public class ShopList
    {

        [Column("SHLIST_ID")]
        [Key]
        public int Id { get; set; }

        public virtual ICollection<ShopProduct> ShopProducts { get; set; }
    }
}