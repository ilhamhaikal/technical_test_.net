using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Services.Contracts
{
    public interface IJadwalAngsuranBayarTotalService
    {
        Task<JadwalAngsuranBayarTotal> Get(string id);

    }
}                                                       
