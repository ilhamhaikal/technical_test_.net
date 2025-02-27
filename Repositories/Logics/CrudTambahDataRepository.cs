using Dapper;
using Npgsql;
using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;

namespace HitungAngsuranMobile.Repositories.Logics
{
    public class CrudTambahDataRepository : ICrudTambahDataRepository
    {
        private readonly string _connectionString;

        public CrudTambahDataRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") 
                ?? throw new ArgumentNullException(nameof(configuration), "Connection string 'DefaultConnection' not found.");
        }

        public async Task<List<CrudDataAngsuran>> GetAllData()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var query = @"
                SELECT 
                    id as Id,
                    kontrak_no as KONTRAK_NO,
                    angsuran_ke as ANGSURAN_KE,
                    angsuran_per_bulan as ANGSURAN_PER_BULAN,
                    tanggal_jatuh_tempo as TANGGAL_JATUH_TEMPO
                FROM crud_test 
                ORDER BY id";

            return (await connection.QueryAsync<CrudDataAngsuran>(query)).ToList();
        }

        public async Task<CrudDataAngsuran> GetDataById(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var query = @"
                SELECT 
                    id as Id,
                    kontrak_no as KONTRAK_NO,
                    angsuran_ke as ANGSURAN_KE,
                    angsuran_per_bulan as ANGSURAN_PER_BULAN,
                    tanggal_jatuh_tempo as TANGGAL_JATUH_TEMPO
                FROM crud_test 
                WHERE id = @Id";

            return await connection.QueryFirstOrDefaultAsync<CrudDataAngsuran>(query, new { Id = id });
        }

        public async Task<CrudDataAngsuran> TambahData(CrudDataAngsuran data)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var query = @"
                INSERT INTO crud_test 
                    (kontrak_no, angsuran_ke, angsuran_per_bulan, tanggal_jatuh_tempo)
                VALUES 
                    (@KONTRAK_NO, @ANGSURAN_KE, @ANGSURAN_PER_BULAN, @TANGGAL_JATUH_TEMPO)
                RETURNING 
                    id as Id,
                    kontrak_no as KONTRAK_NO,
                    angsuran_ke as ANGSURAN_KE,
                    angsuran_per_bulan as ANGSURAN_PER_BULAN,
                    tanggal_jatuh_tempo as TANGGAL_JATUH_TEMPO";

            return await connection.QuerySingleAsync<CrudDataAngsuran>(query, data);
        }

        public async Task<CrudDataAngsuran> EditData(CrudDataAngsuran data)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var query = @"
                UPDATE crud_test 
                SET 
                    kontrak_no = @KONTRAK_NO,
                    angsuran_ke = @ANGSURAN_KE,
                    angsuran_per_bulan = @ANGSURAN_PER_BULAN,
                    tanggal_jatuh_tempo = @TANGGAL_JATUH_TEMPO
                WHERE id = @Id
                RETURNING 
                    id as Id,
                    kontrak_no as KONTRAK_NO,
                    angsuran_ke as ANGSURAN_KE,
                    angsuran_per_bulan as ANGSURAN_PER_BULAN,
                    tanggal_jatuh_tempo as TANGGAL_JATUH_TEMPO";

            return await connection.QuerySingleAsync<CrudDataAngsuran>(query, data);
        }

        public async Task<bool> HapusData(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var query = "DELETE FROM crud_test WHERE id = @Id";
            var result = await connection.ExecuteAsync(query, new { Id = id });
            return result > 0;
        }
    }
}