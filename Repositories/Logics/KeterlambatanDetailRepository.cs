using Dapper;
using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using Npgsql;

namespace HitungAngsuranMobile.Repositories.Logics
{
    public class KeterlambatanDetailRepository : IKeterlambatanDetailRepository
    {
        private readonly string _connectionString;
        public KeterlambatanDetailRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<List<KeterlambatanDetail>> GetKeterlambatan(string id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = @"
                    SELECT 
                        KONTRAK_NO,
                        'SUGUS' AS CLIENT_NAME,
                        ANGSURAN_KE,
                        (DATE '2024-08-14' - TANGGAL_JATUH_TEMPO) AS HARI_KETERLAMBATAN,
                        ((DATE '2024-08-14' - TANGGAL_JATUH_TEMPO) * 0.001 * ANGSURAN_PER_BULAN) AS TOTAL_DENDA
                    FROM JADWAL_ANGSURAN
                    WHERE KONTRAK_NO = @KontrakNo
                    AND TANGGAL_JATUH_TEMPO BETWEEN '2024-06-25' AND '2024-07-25'
                    ORDER BY TANGGAL_JATUH_TEMPO;";
            return (await connection.QueryAsync<KeterlambatanDetail>(query, new { KontrakNo = id })).ToList();
        }
    }
}
