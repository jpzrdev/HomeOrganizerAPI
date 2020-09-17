using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeOrganizerAPI.Model
{
    public class ShopListProduct
    {
        [Key, Column(Order = 1)]
        public int IdShopProduct { get; set; }
        [Key, Column(Order = 2)]
        public int IdShopList { get; set; }
        public ShopProduct ShopProduct { get; set; }
        public ShopList ShopList { get; set; }

    }
}