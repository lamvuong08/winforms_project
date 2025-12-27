using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaKhoa.Models
{
    [Table("CHANDOAN")]
    public class ChanDoan
    {
        [Key]
        [StringLength(20)]
        public string MaCD { get; set; }

        // Khóa ngoại liên kết tới LAMSAN (nvarchar 20)
        [StringLength(20)]
        public string MaLS { get; set; }

        public string TenChuanDoan { get; set; } // nvarchar(MAX)

        // --- MAPPING / NAVIGATION PROPERTIES ---
        // Mapping: FK_CHANDOAN_LAMSAN REFERENCES LAMSAN(MaLS)
        public virtual LamSan Lamsan { get; set; }

        // Một Chẩn đoán có thể có nhiều dòng Điều trị chi tiết
        public virtual ICollection<DieuTri> Dieutris { get; set; }
    }
}
