using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VillaAPI.Data;
using VillaAPI.Logging;
using VillaAPI.Models;
using VillaAPI.Models.Dto;
using VillaAPI.Reporitories;

namespace VillaAPI.Controllers
{
    [ApiController]
    [Route("app/[controller]")]
    public class VillaAPIController : ControllerBase
    {
        private readonly ILogging _logger;
        private readonly IMapper _mapper;
        private readonly IVillaRepository _villaRepository;
        public VillaAPIController(ILogging logger, IMapper mapper, IVillaRepository villaRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _villaRepository = villaRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VillaDto>>> GetVillas()
        {
            _logger.Log("Getting all villas", "");
            return Ok(_mapper.Map<List<VillaDto>>(await _villaRepository.GetAllVillasAsync()));
        }

        [HttpGet("id", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDto>> GetVilla(int id)
        {
            if (id == 0)
            {
                _logger.Log("Get Villa Error with Id: " + id, "error");
                return BadRequest("Invalid ID");
            }
            var villa = await _villaRepository.GetVillaAsync(id);
            return villa == null ? NotFound() : Ok(_mapper.Map<VillaDto>(villa));
        }

        [HttpPost(Name = "CreateVilla")]
        public async Task<ActionResult<int>> CreateVilla([FromBody] VillaCreateDto villaDto)
        {
            if (villaDto == null)
            {
                return BadRequest("Cannot insert null value");
            }
            try
            {
                var villaId = await _villaRepository.AddVillaAsync(villaDto);
                return CreatedAtRoute("CreateVilla", new { Id = villaId }, villaId);
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message, "error");
                return BadRequest(ex.Message);
            }       
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<int>> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest("Invalid id");
            }

            try
            {
                var villaId = await _villaRepository.DeleteVillaAsync(id);
                if (villaId == VillaRepository.DELETE_NOT_FOUND)
                {
                    return NotFound(VillaRepository.DELETE_NOT_FOUND);
                }
                else
                {
                    return Ok(villaId);
                }
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message, "error");
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> UpdateVilla(int id, [FromBody] VillaUpdateDto villaDto)
        {
            try
            {
                return Ok(await _villaRepository.UpdateVillaAsync(id, villaDto));
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message, "error");
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}", Name = "UpdatePartialVilla")]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await _villaRepository.GetVillaAsync(id);
            var villaDto = _mapper.Map<VillaUpdateDto>(villa);
            if (villaDto == null)
            {
                return BadRequest();
            }
            patchDto.ApplyTo(villaDto, ModelState);
           // Villa model = _mapper.Map<Villa>(villaDto);

            await _villaRepository.UpdateVillaAsync(id, villaDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
