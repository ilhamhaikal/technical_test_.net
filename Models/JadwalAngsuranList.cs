namespace HitungAngsuranMobile.Models
{
    public class JadwalAngsuranList
    {
        public string KONTRAK_NO { get; set; } = string.Empty;
        public string ANGSURAN_KE { get; set; } = string.Empty;
        public decimal ANGSURAN_PER_BULAN { get; set; }
        public DateTime TANGGAL_JATUH_TEMPO { get; set; }
    }
}
