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
        public required string KONTRAK_NO { get; set; }
        public required string ANGSURAN_KE { get; set; }
        public required decimal ANGSURAN_PER_BULAN { get; set; }
        public DateTime TANGGAL_JATUH_TEMPO { get; set; }
    }
}
