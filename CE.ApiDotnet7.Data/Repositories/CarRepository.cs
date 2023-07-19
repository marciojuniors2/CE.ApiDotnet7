using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;
using CE.ApiDotnet7.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CE.ApiDotnet7.Infra.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CeContext _db;

        public CarRepository(CeContext db)
        {
            _db = db;
        }

        public async Task<Car> CreateAsync(Car Car)
        {
            _db.Add(Car);
            await _db.SaveChangesAsync();
            return Car;
        }

        public async Task DeleteAsync(Car Car)
        {
            _db.Remove(Car);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Car Car)
        {
            _db.Update(Car);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Car>> GetAllAsync()
        {
            return await _db.Cars.OrderBy(c => c.Price).ToListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _db.Cars.FirstOrDefaultAsync(x => x.Id == id);
        }


    }
}