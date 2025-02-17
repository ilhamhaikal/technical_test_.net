using HitungAngsuranMobile.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HitungAngsuranMobile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JsonDataUserController : ControllerBase
    {
        private readonly IJsonDataUserService _jsonDataUserService;
        public JsonDataUserController(IJsonDataUserService jsonDataUserService)
        {
            _jsonDataUserService = jsonDataUserService;
        }
        [HttpGet]
            public IActionResult Index(int start, int length)
        {
            var result = _jsonDataUserService.GetAll(start, length).Result;
            return Ok(result);
        }
    }
}
