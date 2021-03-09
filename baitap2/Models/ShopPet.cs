

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baitap2.Models
{
    [Table("ShopPets")]
    public class ShopPet
    {
        [Key]
        public string IDPet { get; set; }
        public string TenPet { get; set; }
        public string LoaiPet { get; set; }
        public string TuoiCuaPet { get; set; }

    }
}