using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Services.Contracts
{
    public interface IJsonDataUserService
    {
        Task<ListDataTable<JsonDataUser>> GetAll(int page, int length);
    }
}
