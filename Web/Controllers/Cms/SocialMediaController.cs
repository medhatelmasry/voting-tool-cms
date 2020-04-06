using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Models.Domain;

namespace Web.Controllers.Cms
{
    public class SocialMediaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly int _managedElectionID;

        public SocialMediaController(ApplicationDbContext context)
        {
            _context = context;
            _managedElectionID = _context.StateSingleton.Find(State.STATE_ID).ManagedElectionID;
        }

        // GET: SocialMedia
        public async Task<IActionResult> Index()
        {
            return View(await _context.SocialMedia
                .Where(sm => sm.ElectionId == _managedElectionID)
                .ToListAsync());
        }

        // GET: SocialMedia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMedia = await _context.SocialMedia
                .FirstOrDefaultAsync(m => m.ID == id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return View(socialMedia);
        }

        // GET: SocialMedia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SocialMedia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MediaName,Message,Link")] SocialMedia socialMedia)
        {
            socialMedia.ElectionId = _managedElectionID;

            if (ModelState.IsValid)
            {
                _context.Add(socialMedia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialMedia);
        }

        // GET: SocialMedia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMedia = await _context.SocialMedia.FindAsync(id);
            if (socialMedia == null)
            {
                return NotFound();
            }
            return View(socialMedia);
        }

        // POST: SocialMedia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MediaName,Message,Link")] SocialMedia socialMedia)
        {
            if (id != socialMedia.ID)
            {
                return NotFound();
            }

            socialMedia.ElectionId = _managedElectionID;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialMedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialMediaExists(socialMedia.ID))
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
            return View(socialMedia);
        }

        // GET: SocialMedia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMedia = await _context.SocialMedia
                .FirstOrDefaultAsync(m => m.ID == id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return View(socialMedia);
        }

        // POST: SocialMedia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialMedia = await _context.SocialMedia.FindAsync(id);
            _context.SocialMedia.Remove(socialMedia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialMediaExists(int id)
        {
            return _context.SocialMedia.Any(e => e.ID == id);
        }
    }
}
