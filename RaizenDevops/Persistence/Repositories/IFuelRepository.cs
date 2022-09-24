using RaizenDevops.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaizenDevops.API.Persistence.Repositories
{
    public interface IFuelRepository
    {
        Task AddAsync(Fuel fuel);
        Task<Fuel> GetByIdAsync(int id);
        Task<Fuel> GetSearchByFuelNameAsync(string fuelName);
        Task<List<Fuel>> GetAllAsync();
        Task UpdateAsync(Fuel fuel);
    }
}
