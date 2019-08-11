using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelistStartupList.Models;
using AngelistStartupList.Repository;

namespace AngelistStartupList.DomainLogic
{
    public class AfricanStartupDomainLogic : IAfricanStartupDomainLogic
    {
        private AfricanStartupRepository africanStartupRepository;
        public AfricanStartupDomainLogic(AfricanStartupRepository africanStartupRepository)
        {
            this.africanStartupRepository = africanStartupRepository;
        }
        public async Task<List<AfricanStartup>> GetByCountryAsync(string country)
        {
            if (country == null)
                return await africanStartupRepository.GetByCountryAsync("South Africa");
            else
                return await africanStartupRepository.GetByCountryAsync(country);
        }

        public async Task<List<AfricanStartup>> GetListAsync()
        {
            return await africanStartupRepository.GetAsync();
        }

        public async Task<List<AfricanStartup>> GetByIdAsync(int? id)
        {
            if (id == null)
                return null;
            else
                return await africanStartupRepository.GetByIdAsync(id);
        }

        public async Task Create(string url)
        {
            AfricanStartup africanStartup = new AfricanStartup
            {
                AngellistUrl = url
            };

            await africanStartupRepository.Create(africanStartup);
        }
    }
}
