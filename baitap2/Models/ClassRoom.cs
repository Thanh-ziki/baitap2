using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace baitap2.Models
{
    [Table("ClassRooms")]
    public class ClassRoom
    {
        [Key]
        public  string HoVaTienSinhVien { get; set; }
        public string MaSinhVien { get; set; }
        public string KhoaHoc { get; set; }
        public string DangKyMonHoc { get; set; }
    }
}