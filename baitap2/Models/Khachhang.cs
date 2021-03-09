using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace baitap2.Models
{
    [Table("Khachhangs")]
    public class Khachhang
    {
        [Key]
        public string Idkhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public string Quequan { get; set; }
        public string Tuoi { get; set; }

    }
}