using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeOrganizerAPI.Model
{
    public class ShopProduct
    {
        [Column("SHPDR_ID")]
        [Key]
        public int Id { get; set; }

        [Column("SHPDR_NAME")]
        public string Name { get; set; }

        public virtual ICollection<ShopList> ShopLists { get; set; }
    }
}