using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Repositories.Logics;
using HitungAngsuranMobile.Services.Contracts;

namespace HitungAngsuranMobile.Services.Logics
{
    public class JsonDataUserService : IJsonDataUserService
    {
        private readonly IJsonDataUserRepository _jsonDataUserRepository;
        public JsonDataUserService()
        {
            _jsonDataUserRepository = new JsonDataUserRepository();
        }
        public Task<ListDataTable<JsonDataUser>> GetAll(int page, int length)
        {
            var data = _jsonDataUserRepository.GetAll(page, length).Result;
            int datacount = data.Count;
            var listdata = data.Skip(page).Take(length).ToList();

            var result = new ListDataTable<JsonDataUser>
            {
                Data = listdata,
                RecordsTotal = listdata.Count,
                RecordsFiltered = datacount,
            };
            return Task.FromResult(result);
        }
    }
}
