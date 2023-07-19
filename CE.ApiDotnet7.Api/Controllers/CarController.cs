using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CE.ApiDotnet7.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CarDTO carDTO)
        {
            var result = await _carService.CreateAsync(carDTO);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _carService.GetAsync();
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetIdAsync(int id)
        {
            var result = await _carService.GetByIdAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        [Route("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] CarDTO carDTO)
        {
            carDTO.Id = id;
            var result = await _carService.UpdateAsync(carDTO);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize] 
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _carService.RemoveAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
