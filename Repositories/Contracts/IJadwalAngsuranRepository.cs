using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Repositories.Contracts
{
    public interface IJadwalAngsuranRepository
    {
        Task<List<JadwalAngsuranList>> GetAll();
    }
}
