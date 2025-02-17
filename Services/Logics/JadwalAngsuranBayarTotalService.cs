using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Repositories.Logics;
using HitungAngsuranMobile.Services.Contracts;

namespace HitungAngsuranMobile.Services.Logics
{
    public class JadwalAngsuranBayarTotalService : IJadwalAngsuranBayarTotalService
    {
        private readonly IJadwalAngsuranBayarTotalRepository _jadwalAngsuranBayarTotalRepository;

        public JadwalAngsuranBayarTotalService(IConfiguration configuration)
        {
            _jadwalAngsuranBayarTotalRepository = new JadwalAngsuranBayarTotalRepository(configuration);
        }

        public async Task<JadwalAngsuranBayarTotal> Get(string id)
        {
            return await _jadwalAngsuranBayarTotalRepository.Get(id);
        }
    }
}
