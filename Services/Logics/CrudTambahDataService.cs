using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Services.Contracts;
using Microsoft.Extensions.Logging;

namespace HitungAngsuranMobile.Services.Logics
{
    public class CrudTambahDataService : ICrudTambahDataService
    {
        private readonly ICrudTambahDataRepository _repository;
        private readonly ILogger<CrudTambahDataService> _logger;

        public CrudTambahDataService(ICrudTambahDataRepository repository, 
            ILogger<CrudTambahDataService> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<CrudDataAngsuran>> GetAllData()
        {
            return await _repository.GetAllData();
        }

        public async Task<CrudDataAngsuran> GetDataById(int id)
        {
            return await _repository.GetDataById(id);
        }

        public async Task<CrudDataAngsuran> TambahData(CrudDataAngsuran data)
        {
            try
            {
                return await _repository.TambahData(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding data {@Data}", data);
                throw;
            }
        }

        public async Task<CrudDataAngsuran> EditData(CrudDataAngsuran data)
        {
            return await _repository.EditData(data);
        }

        public async Task<bool> HapusData(int id)
        {
            return await _repository.HapusData(id);
        }
    }
}