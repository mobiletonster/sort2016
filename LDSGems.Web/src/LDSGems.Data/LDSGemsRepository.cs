using LDSGems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSGems.Data
{
    public interface ILDSGemsRepository
    {
        IQueryable<DailyGems> GetDailyGems();
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
    }
}
