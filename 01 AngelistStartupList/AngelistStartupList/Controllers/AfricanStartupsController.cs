using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AngelistStartupList.Models;
using AngelistStartupList.DomainLogic;
using AngelistStartupList.Repository;

namespace AngelistStartupList.Controllers
{
    public class AfricanStartupsController : Controller
    {
        private readonly AngelistContext _context;
        private AfricanStartupRepository africanStartupRepository;
        private AfricanStartupDomainLogic africanStartupDomainLogic;

        public AfricanStartupsController(AngelistContext context)
        {
            _context = context;
            this.africanStartupRepository = new AfricanStartupRepository();
            this.africanStartupDomainLogic = new AfricanStartupDomainLogic(africanStartupRepository);
        }

        // GET: AfricanStartups?country={country}
        public async Task<IActionResult> Index(string country)
        {
            if (country == null)
            {
                return View(await africanStartupDomainLogic.GetListAsync());
            }

            var africanStartup = await africanStartupDomainLogic.GetByCountryAsync(country);

            if (africanStartup == null)
            {
                return NotFound();
            }

            return View(africanStartup);
        }

        // GET: AfricanStartups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var africanStartup = await africanStartupDomainLogic.GetByIdAsync(id);

            if (africanStartup == null)
            {
                return NotFound();
            }

            return View(africanStartup);
        }

        // GET: AfricanStartups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AfricanStartups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListId,AngellistUrl,BlogUrl,CommunityProfile,CompanySize,CompanyType,CompanyUrl,Country,CreatedAt,CrunchbaseUrl,FacebookUrl,FollowerCount,HighConcept,Id,LinkedinUrl,Locations,LogoUrl,Markets,Name,ProductDesc,Quality,Screenshots,Status,ThumbUrl,TwitterUrl,UpdatedAt,VideoUrl")] AfricanStartup africanStartup)
        {
            if (ModelState.IsValid)
            {
                await africanStartupDomainLogic.Create(africanStartup.AngellistUrl);
            }
            return View(africanStartup);
        }

        // GET: AfricanStartups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var africanStartup = await _context.AfricanStartup.FindAsync(id);
            if (africanStartup == null)
            {
                return NotFound();
            }
            return View(africanStartup);
        }

        // POST: AfricanStartups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListId,AngellistUrl,BlogUrl,CommunityProfile,CompanySize,CompanyType,CompanyUrl,Country,CreatedAt,CrunchbaseUrl,FacebookUrl,FollowerCount,HighConcept,Id,LinkedinUrl,Locations,LogoUrl,Markets,Name,ProductDesc,Quality,Screenshots,Status,ThumbUrl,TwitterUrl,UpdatedAt,VideoUrl")] AfricanStartup africanStartup)
        {
            if (id != africanStartup.ListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(africanStartup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfricanStartupExists(africanStartup.ListId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(africanStartup);
        }

        // GET: AfricanStartups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var africanStartup = await _context.AfricanStartup
                .FirstOrDefaultAsync(m => m.ListId == id);
            if (africanStartup == null)
            {
                return NotFound();
            }

            return View(africanStartup);
        }

        // POST: AfricanStartups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var africanStartup = await _context.AfricanStartup.FindAsync(id);
            _context.AfricanStartup.Remove(africanStartup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfricanStartupExists(int id)
        {
            return _context.AfricanStartup.Any(e => e.ListId == id);
        }
    }
}
