using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Repositories.Contracts
{
    public interface IJsonDataUserRepository
    {
        Task<List<JsonDataUser>> GetAll(int page, int length);
    }
}
