using AngelistStartupList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngelistStartupList.Repository
{
    public interface IAfricanStartupRepository
    {
        Task<List<AfricanStartup>> GetAsync();
        Task<List<AfricanStartup>> GetByIdAsync(int? id);
        Task<List<AfricanStartup>> GetByCountryAsync(string country);
        Task Create(AfricanStartup africanStartup);
    }
}
