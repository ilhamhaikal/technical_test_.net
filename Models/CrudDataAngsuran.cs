using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HitungAngsuranMobile.Models
{
    [Table("crud_test")]
    public class CrudDataAngsuran
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column("kontrak_no")]
        public string KONTRAK_NO { get; set; } = string.Empty;
        
        [Required]
        [Column("angsuran_ke")]
        public int ANGSURAN_KE { get; set; }
        
        [Required]
        [Column("angsuran_per_bulan")]
        public decimal ANGSURAN_PER_BULAN { get; set; }
        
        [Required]
        [Column("tanggal_jatuh_tempo")]
        public DateTime TANGGAL_JATUH_TEMPO { get; set; }
    }
}
