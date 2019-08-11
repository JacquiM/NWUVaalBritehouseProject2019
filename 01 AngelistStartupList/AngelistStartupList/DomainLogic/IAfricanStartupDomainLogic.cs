using AngelistStartupList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngelistStartupList.DomainLogic
{
    public interface IAfricanStartupDomainLogic
    {
        Task<List<AfricanStartup>> GetListAsync();
        Task<List<AfricanStartup>> GetByIdAsync(int? id);
        Task<List<AfricanStartup>> GetByCountryAsync(string country);

        Task Create(string url);
    }
}
