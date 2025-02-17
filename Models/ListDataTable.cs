namespace HitungAngsuranMobile.Models
{
    //respond data table hanya 3 field
    public class ListDataTable<T>
    {
        public List<T> Data { get; set; } = [];
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
    }
}
