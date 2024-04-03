using VillaAPI.Models;
using VillaAPI.Models.Dto;

namespace VillaAPI.Reporitories
{
    public interface IVillaRepository
    {
        public Task<List<Villa>> GetAllVillasAsync();
        public Task<Villa> GetVillaAsync(int id);
        public Task<int> AddVillaAsync(VillaCreateDto model);
        public Task<int> UpdateVillaAsync(int id, VillaUpdateDto model);
        public Task<int> DeleteVillaAsync(int id);
    }
}
