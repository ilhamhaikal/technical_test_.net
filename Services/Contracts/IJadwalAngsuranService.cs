using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Services.Contracts
{
    public interface IJadwalAngsuranService
    {
        Task<List<JadwalAngsuranList>> GetAll();
    }
}
