using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Repositories.Logics;
using HitungAngsuranMobile.Services.Contracts;

namespace HitungAngsuranMobile.Services.Logics
{
    public class JadwalAngsuranService : IJadwalAngsuranService
    {
        private readonly IJadwalAngsuranRepository _jadwalAngsuranRepository;
        public JadwalAngsuranService(IConfiguration configuration)
        {
            _jadwalAngsuranRepository = new JadwalAngsuranRepository(configuration);
        }
        public Task<List<JadwalAngsuranList>> GetAll()
        {
            return _jadwalAngsuranRepository.GetAll();
        }
    }
}
