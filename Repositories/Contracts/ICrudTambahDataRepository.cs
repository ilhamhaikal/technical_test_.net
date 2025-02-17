using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Repositories.Contracts
{
    public interface ICrudTambahDataRepository
    {
        Task<List<CrudDataAngsuran>> GetAllData();
        Task<CrudDataAngsuran> GetDataById(int id);
        Task<CrudDataAngsuran> TambahData(CrudDataAngsuran data);
        Task<CrudDataAngsuran> EditData(CrudDataAngsuran data);
        Task<bool> HapusData(int id);
    }
}