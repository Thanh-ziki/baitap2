

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baitap2.Models
{
    [Table("Acconuts")]
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Passwork { get; set; }
    }
}