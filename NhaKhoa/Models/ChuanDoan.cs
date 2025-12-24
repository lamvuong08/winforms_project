using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaKhoa.Models
{
    [Table("CHAN_DOAN")]
    public class ChuanDoan
    {
        [Key]
        [StringLength(50)]
        public string MaCD { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayChuanDoan { get; set; }
        public string MaBN { get; set; }
        public string MaNV { get; set; }
        public string MaTLS { get; set; }
        public virtual BenhNhan BenhNhan { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
