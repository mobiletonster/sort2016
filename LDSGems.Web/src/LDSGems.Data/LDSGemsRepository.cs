using LDSGems.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSGems.Data
{
    public interface ILDSGemsRepository
    {
        IQueryable<DailyGems> GetDailyGems();
        Task<object> UpdateRecordAsync(object entity);
    }
    public class LDSGemsRepository: ILDSGemsRepository
    {
        private LDSGemsContext _context;
        public LDSGemsRepository(LDSGemsContext context)
        {
            _context = context;
        }

        public IQueryable<DailyGems> GetDailyGems()
        {
            return _context.DailyGems;
        }

        public async Task<object> UpdateRecordAsync(object entity)
        {
            var dbEntity = _context.Entry(entity);
            dbEntity.State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbEntity.State = EntityState.Detached;
            }
            return dbEntity.Entity;
        }
    }
}
