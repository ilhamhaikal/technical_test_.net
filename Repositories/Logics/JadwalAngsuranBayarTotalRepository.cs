using Dapper;
using Npgsql;
using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;

namespace HitungAngsuranMobile.Repositories.Logics
{
    public class JadwalAngsuranBayarTotalRepository : IJadwalAngsuranBayarTotalRepository
    {
        private readonly string _connectionString;
        public JadwalAngsuranBayarTotalRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<JadwalAngsuranBayarTotal> Get(string id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = @"
                    SELECT 
                        KONTRAK_NO, 
                        'SUGUS' AS CLIENT_NAME, 
                        SUM(ANGSURAN_PER_BULAN) AS TOTAL_ANGSURAN_JATUH_TEMPO
                    FROM JADWAL_ANGSURAN 
                    WHERE KONTRAK_NO = @KontrakNo
                    AND TANGGAL_JATUH_TEMPO <= '2024-08-14'
                    GROUP BY KONTRAK_NO";

            return await connection.QueryFirstOrDefaultAsync<JadwalAngsuranBayarTotal>(query, new { KontrakNo = id });
        }
    }
}