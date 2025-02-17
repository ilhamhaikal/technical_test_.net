using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Services.Contracts
{
    public interface IKeterlambatanDetailService
    {
        Task<List<KeterlambatanDetail>> GetKeterlambatan(string id);
    }
}
