using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HitungAngsuranMobile.Models
{
    [Table("jadwal_angsuran")]
    public class CrudDataAngsuran
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public required string KONTRAK_NO { get; set; }
        
        [Required]
        public int ANGSURAN_KE { get; set; } 
        
        [Required]
        public required decimal ANGSURAN_PER_BULAN { get; set; }
        
        [Required]
        public DateTime TANGGAL_JATUH_TEMPO { get; set; }
    }
}
