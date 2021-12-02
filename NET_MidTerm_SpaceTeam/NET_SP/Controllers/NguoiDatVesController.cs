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
    public class NguoiDatVesController : Controller
    {
        private readonly MyDbContext _context;

        public NguoiDatVesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NguoiDatVes
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NguoiDatVes.Include(n => n.LCP);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NguoiDatVes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDatVe = await _context.NguoiDatVes
                .Include(n => n.LCP)
                .FirstOrDefaultAsync(m => m.MaNguoiDatVe == id);
            if (nguoiDatVe == null)
            {
                return NotFound();
            }

            return View(nguoiDatVe);
        }

        // GET: NguoiDatVes/Create
        public IActionResult Create()
        {
            ViewData["MaChieuPhim"] = new SelectList(_context.LichChieuPhim, "MaChieuPhim", "MaChieuPhim");
            return View();
        }

        // POST: NguoiDatVes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNguoiDatVe,SoDienThoai,DiaChi,SoLuongDat,MaChieuPhim")] NguoiDatVe nguoiDatVe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoiDatVe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaChieuPhim"] = new SelectList(_context.LichChieuPhim, "MaChieuPhim", "MaChieuPhim", nguoiDatVe.MaChieuPhim);
            return View(nguoiDatVe);
        }

        // GET: NguoiDatVes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDatVe = await _context.NguoiDatVes.FindAsync(id);
            if (nguoiDatVe == null)
            {
                return NotFound();
            }
            ViewData["MaChieuPhim"] = new SelectList(_context.LichChieuPhim, "MaChieuPhim", "MaChieuPhim", nguoiDatVe.MaChieuPhim);
            return View(nguoiDatVe);
        }

        // POST: NguoiDatVes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaNguoiDatVe,SoDienThoai,DiaChi,SoLuongDat,MaChieuPhim")] NguoiDatVe nguoiDatVe)
        {
            if (id != nguoiDatVe.MaNguoiDatVe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoiDatVe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDatVeExists(nguoiDatVe.MaNguoiDatVe))
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
            ViewData["MaChieuPhim"] = new SelectList(_context.LichChieuPhim, "MaChieuPhim", "MaChieuPhim", nguoiDatVe.MaChieuPhim);
            return View(nguoiDatVe);
        }

        // GET: NguoiDatVes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDatVe = await _context.NguoiDatVes
                .Include(n => n.LCP)
                .FirstOrDefaultAsync(m => m.MaNguoiDatVe == id);
            if (nguoiDatVe == null)
            {
                return NotFound();
            }

            return View(nguoiDatVe);
        }

        // POST: NguoiDatVes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoiDatVe = await _context.NguoiDatVes.FindAsync(id);
            _context.NguoiDatVes.Remove(nguoiDatVe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiDatVeExists(int id)
        {
            return _context.NguoiDatVes.Any(e => e.MaNguoiDatVe == id);
        }
    }
}
