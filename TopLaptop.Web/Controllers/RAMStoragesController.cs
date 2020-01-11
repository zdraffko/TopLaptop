using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopLaptop.Data.Context;
using TopLaptop.Data.Entities.Laptops.LaptopParts;

namespace TopLaptop.Web.Controllers
{
    public class RAMStoragesController : Controller
    {
        private readonly TopLaptopDbContext _context;

        public RAMStoragesController(TopLaptopDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.RAMStorages.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAMStorage = await _context.RAMStorages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rAMStorage == null)
            {
                return NotFound();
            }

            return View(rAMStorage);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Size")] RAMStorage rAMStorage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rAMStorage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rAMStorage);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAMStorage = await _context.RAMStorages.FindAsync(id);
            if (rAMStorage == null)
            {
                return NotFound();
            }
            return View(rAMStorage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Size")] RAMStorage rAMStorage)
        {
            if (id != rAMStorage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rAMStorage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RAMStorageExists(rAMStorage.Id))
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
            return View(rAMStorage);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAMStorage = await _context.RAMStorages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rAMStorage == null)
            {
                return NotFound();
            }

            return View(rAMStorage);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rAMStorage = await _context.RAMStorages.FindAsync(id);
            _context.RAMStorages.Remove(rAMStorage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RAMStorageExists(int id)
        {
            return _context.RAMStorages.Any(e => e.Id == id);
        }
    }
}
