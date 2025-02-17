using Microsoft.AspNetCore.Mvc;
using HitungAngsuranMobile.Services.Contracts;
using HitungAngsuranMobile.Services.Logics;
using HitungAngsuranMobile.Models;

namespace HitungAngsuranMobile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JadwalAngsuranController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly IJadwalAngsuranService _jadwalAngsuranService;
        private readonly IJadwalAngsuranBayarTotalService _jadwalAngsuranBayarTotalService;
        private readonly IKeterlambatanDetailService _keterlamabatanDetailService;

        public JadwalAngsuranController(IConfiguration configuration, IJadwalAngsuranService jadwalAngsuranService, IJadwalAngsuranBayarTotalService jadwalAngsuranBayarTotalService, IKeterlambatanDetailService keterlambatanDetailService)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _jadwalAngsuranService = jadwalAngsuranService;
            _jadwalAngsuranBayarTotalService = jadwalAngsuranBayarTotalService;
            _keterlamabatanDetailService = keterlambatanDetailService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JadwalAngsuranBayarTotal>> Get(string id)
        {
            try
            {
                var result = await _jadwalAngsuranBayarTotalService.Get(id);
                if (result == null)
                {
                    return NotFound($"No record found for id: {id}");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database error: {ex.Message}");
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<JadwalAngsuranList>>> GetList()
        {
            try
            {
                var result = await _jadwalAngsuranService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database error: {ex.Message}");
            }
        }

        [HttpGet("keterlambatan/{id}")]
        public async Task<ActionResult<List<KeterlambatanDetail>>> GetKeterlambatan(string id)
        {
            try
            {
                var result = await _keterlamabatanDetailService.GetKeterlambatan(id);
                if (result == null)
                {
                    return NotFound($"No record found for id: {id}");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database error: {ex.Message}");
            }
        }
    }
}