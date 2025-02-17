using Microsoft.AspNetCore.Mvc;
using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Services.Contracts;

namespace HitungAngsuranMobile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly ICrudTambahDataService _service;

        public CrudController(ICrudTambahDataService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<CrudDataAngsuran>>> GetData()
        {
            try
            {
                var result = await _service.GetAllData();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CrudDataAngsuran>> GetDataById(int id)
        {
            try
            {
                var result = await _service.GetDataById(id);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CrudDataAngsuran>> TambahData(CrudDataAngsuran data)
        {
            try
            {
                var result = await _service.TambahData(data);
                return CreatedAtAction(nameof(GetDataById), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CrudDataAngsuran>> EditData(int id, CrudDataAngsuran data)
        {
            try
            {
                if (id != data.Id) return BadRequest();
                var result = await _service.EditData(data);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> HapusData(int id)
        {
            try
            {
                var result = await _service.HapusData(id);
                if (!result) return NotFound();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
