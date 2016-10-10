using LDSGems.Data;
using LDSGems.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSGems.Services
{
    public class LDSGemsService
    {
        private ILDSGemsRepository _repository;
        public LDSGemsService(ILDSGemsRepository repository)
        {
            _repository = repository;
        }

        public LDSGemsService(LDSGemsContext context)
        {
            _repository = new LDSGemsRepository(context);
        }

        public async Task<List<DailyGems>> GetDailyGemsAsync()
        {
            return await _repository.GetDailyGems().ToListAsync();
        }
    }
}
