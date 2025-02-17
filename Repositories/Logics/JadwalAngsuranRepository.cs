using Dapper;
using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using Npgsql;

namespace HitungAngsuranMobile.Repositories.Logics
{
    public class JadwalAngsuranRepository : IJadwalAngsuranRepository
    {
        private readonly string _connectionString;
        public JadwalAngsuranRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<List<JadwalAngsuranList>> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = @"
                    SELECT 
                        KONTRAK_NO,
                        ANGSURAN_KE,
                        ANGSURAN_PER_BULAN,
                        TANGGAL_JATUH_TEMPO
                    FROM JADWAL_ANGSURAN
                    ORDER BY TANGGAL_JATUH_TEMPO;"
            ;

            var result = connection.QueryAsync<JadwalAngsuranList>(query).Result;
            return result.ToList();
        }
    }
}
