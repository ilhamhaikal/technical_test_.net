namespace HitungAngsuranMobile.Models
{
    public class KeterlambatanDetail
    {
        public string KONTRAK_NO { get; set; } = string.Empty;
        public string CLIENT_NAME { get; set; } = string.Empty;
        public string ANGSURAN_KE { get; set; } = string.Empty;
        public int HARI_KETERLAMBATAN { get; set; }
        public decimal TOTAL_DENDA { get; set; }
    }
}
