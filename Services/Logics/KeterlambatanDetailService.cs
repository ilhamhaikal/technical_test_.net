using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Repositories.Logics;
using HitungAngsuranMobile.Services.Contracts;

namespace HitungAngsuranMobile.Services.Logics
{
    public class KeterlambatanDetailService : IKeterlambatanDetailService
    {
        private readonly IKeterlambatanDetailRepository _keterlambatanDetailRepository;
        public KeterlambatanDetailService(IConfiguration configuration)
        {
            _keterlambatanDetailRepository = new KeterlambatanDetailRepository(configuration);
        }
        public Task<List<KeterlambatanDetail>> GetKeterlambatan(string id)
        {
            return _keterlambatanDetailRepository.GetKeterlambatan(id);
        }
    }
}
