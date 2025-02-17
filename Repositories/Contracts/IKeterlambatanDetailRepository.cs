using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Repositories.Contracts
{
    public interface IKeterlambatanDetailRepository
    {
        Task<List<KeterlambatanDetail>> GetKeterlambatan(string id);
    }
}
