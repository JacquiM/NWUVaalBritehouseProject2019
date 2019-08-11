using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelistStartupList.Models;
using Microsoft.EntityFrameworkCore;

namespace AngelistStartupList.Repository
{
    public class AfricanStartupRepository : IAfricanStartupRepository
    {
        private AngelistContext angelistContext;
        public AfricanStartupRepository()
        {
            this.angelistContext = new AngelistContext();
        }

        public async Task Create(AfricanStartup africanStartup)
        {
            var result = await angelistContext.Set<AfricanStartup>().AddAsync(africanStartup);
            await angelistContext.SaveChangesAsync();
        }

        public async Task<List<AfricanStartup>> GetAsync()
        {
            return await angelistContext.AfricanStartup.ToListAsync();
        }

        public async Task<List<AfricanStartup>> GetByCountryAsync(string country)
        {
           return await angelistContext.AfricanStartup.Where(m => m.Country == country).ToListAsync();
        }

        public async Task<List<AfricanStartup>> GetByIdAsync(int? id)
        {
            return await angelistContext.AfricanStartup.Where(m => m.ListId == id).ToListAsync();
        }
    }
}
