using Microsoft.EntityFrameworkCore;
using RaizenDevops.Core.Entities;
using RaizenDevops.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaizenDevops.API.Persistence.Repositories
{
    public class FuelRepository : IFuelRepository
    {
        private readonly RaizenDevopsDbContext _dbContext;

        public FuelRepository(RaizenDevopsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Fuel fuel)
        {
            await _dbContext.Fuels.AddAsync(fuel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Fuel>> GetAllAsync()
        {
            return await _dbContext.Fuels.ToListAsync();
        }

        public async Task<Fuel> GetByIdAsync(int id)
        {
            return await _dbContext.Fuels.SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fuel> GetSearchByFuelNameAsync(string fuelName)
        {
            return await _dbContext.Fuels.SingleOrDefaultAsync(f => f.FuelName == fuelName);
        }

        public async Task UpdateAsync(Fuel fuel)
        {
            _dbContext.Fuels.Update(fuel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
