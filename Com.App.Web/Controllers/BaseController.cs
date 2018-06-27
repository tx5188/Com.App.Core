using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Com.App.Data.EntityFramework;
using Com.App.Model.Base;

namespace Com.App.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly MyDbContext _context;



        public BaseController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Dept()
        {
            return View();
        }
        // GET: BaseDeparments
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.BaseDeparment.Include(b => b.BaseCompany);
            return View(await myDbContext.ToListAsync());
        }

        // GET: BaseDeparments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseDeparment = await _context.BaseDeparment
                .Include(b => b.BaseCompany)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseDeparment == null)
            {
                return NotFound();
            }

            return View(baseDeparment);
        }

        // GET: BaseDeparments/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.BaseCompany, "Id", "CompanyName");
            return View();
        }

        // POST: BaseDeparments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,DeptName,ParentId,DeptCode,DepteType,DeptLevel,DeleteFlag,RecordMan,RecordDate,UpdateMan,UpdateDate,CheckMan,CheckDate,Id")] BaseDeparment baseDeparment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baseDeparment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.BaseCompany, "Id", "CompanyName", baseDeparment.CompanyId);
            return View(baseDeparment);
        }

        // GET: BaseDeparments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseDeparment = await _context.BaseDeparment.FindAsync(id);
            if (baseDeparment == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.BaseCompany, "Id", "CompanyName", baseDeparment.CompanyId);
            return View(baseDeparment);
        }

        // POST: BaseDeparments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,DeptName,ParentId,DeptCode,DepteType,DeptLevel,DeleteFlag,RecordMan,RecordDate,UpdateMan,UpdateDate,CheckMan,CheckDate,Id")] BaseDeparment baseDeparment)
        {
            if (id != baseDeparment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baseDeparment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseDeparmentExists(baseDeparment.Id))
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
            ViewData["CompanyId"] = new SelectList(_context.BaseCompany, "Id", "CompanyName", baseDeparment.CompanyId);
            return View(baseDeparment);
        }

        // GET: BaseDeparments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseDeparment = await _context.BaseDeparment
                .Include(b => b.BaseCompany)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseDeparment == null)
            {
                return NotFound();
            }

            return View(baseDeparment);
        }

        // POST: BaseDeparments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var baseDeparment = await _context.BaseDeparment.FindAsync(id);
            _context.BaseDeparment.Remove(baseDeparment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaseDeparmentExists(int id)
        {
            return _context.BaseDeparment.Any(e => e.Id == id);
        }
    }
}
