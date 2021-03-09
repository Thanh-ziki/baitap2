
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baitap2.Models
{
    [Table("ShopGiays")]
    public class ShopGiay
    {
        [Key]
        public string IDKhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public string IDGiay { get; set; }
        public string LoaiGiay { get; set; }

    }
}