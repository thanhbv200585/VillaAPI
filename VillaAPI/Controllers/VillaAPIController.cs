using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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
        protected APIResponse _response;
        private readonly ILogging _logger;
        private readonly IMapper _mapper;
        private readonly IVillaRepository _villaRepository;
        public VillaAPIController(ILogging logger, IMapper mapper, IVillaRepository villaRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _villaRepository = villaRepository;
            _response = new APIResponse();
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            try
            {
                List<Villa> villaList = await _villaRepository.GetAllVillasAsync();
                _response.Result = _mapper.Map<List<VillaDto>>(villaList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
                return BadRequest(_response);
            }
        }

        [HttpGet("{id}", Name = "GetVilla")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {
            if (id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _logger.Log("Get Villa Error with Id: " + id, "error");
                return BadRequest(_response);
            }
            var villa = await _villaRepository.GetVillaAsync(id);
            if (villa == null)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_response);
            }
            _response.Result = _mapper.Map<VillaDto>(villa);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpPost(Name = "CreateVilla")]
        [Authorize(Roles = "admin")]
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
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDto villaDto)
        {
            try
            {
                await _villaRepository.UpdateVillaAsync(id, villaDto);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message, "error");
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
                return BadRequest(_response);
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
