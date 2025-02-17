using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Repositories.Contracts
{
    public interface IJadwalAngsuranBayarTotalRepository
    {
        Task<JadwalAngsuranBayarTotal> Get(string id);
    }
}
