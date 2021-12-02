using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NET_SP.Entities;

namespace NET_SP.Controllers
{
    public class LichChieuPhimsController : Controller
    {
        private readonly MyDbContext _context;

        public LichChieuPhimsController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ShowAll(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myDbContext = _context.NguoiDatVes.Include(n => n.LCP).Where(m => m.MaChieuPhim == id);
            if (myDbContext == null)
            {
                return NotFound();
            }

            return View(await myDbContext.ToListAsync());
        }

        // GET: LichChieuPhims
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.LichChieuPhim.Include(l => l.Phim).Include(l => l.Rap);
            return View(await myDbContext.ToListAsync());
        }

        // GET: LichChieuPhims/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuPhim = await _context.LichChieuPhim
                .Include(l => l.Phim)
                .Include(l => l.Rap)
                .FirstOrDefaultAsync(m => m.MaChieuPhim == id);
            if (lichChieuPhim == null)
            {
                return NotFound();
            }

            return View(lichChieuPhim);
        }

        // GET: LichChieuPhims/Create
        public IActionResult Create()
        {
            ViewData["MaPhim"] = new SelectList(_context.Phims, "MaPhim", "TenPhim");
            ViewData["MaRap"] = new SelectList(_context.Khoas, "MaRap", "TenRap");
            return View();
        }

        // POST: LichChieuPhims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChieuPhim,GioCongChieu,SoLuong,MaPhim,MaRap")] LichChieuPhim lichChieuPhim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lichChieuPhim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhim"] = new SelectList(_context.Phims, "MaPhim", "TenPhim", lichChieuPhim.MaPhim);
            ViewData["MaRap"] = new SelectList(_context.Khoas, "MaRap", "TenRap", lichChieuPhim.MaRap);
            return View(lichChieuPhim);
        }

        // GET: LichChieuPhims/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuPhim = await _context.LichChieuPhim.FindAsync(id);
            if (lichChieuPhim == null)
            {
                return NotFound();
            }
            ViewData["MaPhim"] = new SelectList(_context.Phims, "MaPhim", "TenPhim", lichChieuPhim.MaPhim);
            ViewData["MaRap"] = new SelectList(_context.Khoas, "MaRap", "TenRap", lichChieuPhim.MaRap);
            return View(lichChieuPhim);
        }

        // POST: LichChieuPhims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaChieuPhim,GioCongChieu,SoLuong,MaPhim,MaRap")] LichChieuPhim lichChieuPhim)
        {
            if (id != lichChieuPhim.MaChieuPhim)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lichChieuPhim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichChieuPhimExists(lichChieuPhim.MaChieuPhim))
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
            ViewData["MaPhim"] = new SelectList(_context.Phims, "MaPhim", "TenPhim", lichChieuPhim.MaPhim);
            ViewData["MaRap"] = new SelectList(_context.Khoas, "MaRap", "TenRap", lichChieuPhim.MaRap);
            return View(lichChieuPhim);
        }

        // GET: LichChieuPhims/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuPhim = await _context.LichChieuPhim
                .Include(l => l.Phim)
                .Include(l => l.Rap)
                .FirstOrDefaultAsync(m => m.MaChieuPhim == id);
            if (lichChieuPhim == null)
            {
                return NotFound();
            }

            return View(lichChieuPhim);
        }

        // POST: LichChieuPhims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lichChieuPhim = await _context.LichChieuPhim.FindAsync(id);
            _context.LichChieuPhim.Remove(lichChieuPhim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichChieuPhimExists(string id)
        {
            return _context.LichChieuPhim.Any(e => e.MaChieuPhim == id);
        }
    }
}
