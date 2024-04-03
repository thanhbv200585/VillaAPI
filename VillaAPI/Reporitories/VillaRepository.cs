using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VillaAPI.Data;
using VillaAPI.Exceptions;
using VillaAPI.Models;
using VillaAPI.Models.Dto;

namespace VillaAPI.Reporitories
{
    public class VillaRepository( ApplicationDbContext context, IMapper mapper) : IVillaRepository
    {
        public readonly static int DELETE_NOT_FOUND = -2;

        private readonly ApplicationDbContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<int> AddVillaAsync(VillaCreateDto model)
        {
            _context.Villas.Add(_mapper.Map<Villa>(model));
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task<int> DeleteVillaAsync(int id)
        {
            var deletedVilla = await _context.Villas.FindAsync(id);
            if (deletedVilla != null)
            {
                _context.Villas.Remove(deletedVilla);
                await _context.SaveChangesAsync();
                return deletedVilla.Id;
            }
            return DELETE_NOT_FOUND;
        }

        public async Task<List<Villa>> GetAllVillasAsync()
        {
            return await _context.Villas.ToListAsync(); 
        }

        public async Task<Villa> GetVillaAsync(int id)
        {
            Villa villa = await _context.Villas.FindAsync(id);
            _context.Entry(villa).State = EntityState.Detached;
            return villa;
        }

        public async Task<int> UpdateVillaAsync(int id, VillaUpdateDto model)
        {
            if (model == null)
            {
                throw new VillaException("Input model is null!");
            }
            if (id != model.Id)
            {
                throw new VillaException("Input id must be equal to model ID");
            }
            else
            {
                var villa = _mapper.Map<Villa>(model);
                _context.Entry<Villa>(villa).State = EntityState.Detached;
                _context.Villas.Update(villa);
                await _context.SaveChangesAsync();
                return id;
            }
        }

    }
}
