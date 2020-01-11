using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopLaptop.Data.Context;
using TopLaptop.Data.Entities.Laptops.LaptopParts;

namespace TopLaptop.Web.Controllers
{
    public class GraphicsCardsController : Controller
    {
        private readonly TopLaptopDbContext _context;

        public GraphicsCardsController(TopLaptopDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.GraphicsCards.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graphicsCard = await _context.GraphicsCards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graphicsCard == null)
            {
                return NotFound();
            }

            return View(graphicsCard);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Manufacturer,Model")] GraphicsCard graphicsCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(graphicsCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(graphicsCard);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graphicsCard = await _context.GraphicsCards.FindAsync(id);
            if (graphicsCard == null)
            {
                return NotFound();
            }
            return View(graphicsCard);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Manufacturer,Model")] GraphicsCard graphicsCard)
        {
            if (id != graphicsCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graphicsCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraphicsCardExists(graphicsCard.Id))
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
            return View(graphicsCard);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graphicsCard = await _context.GraphicsCards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graphicsCard == null)
            {
                return NotFound();
            }

            return View(graphicsCard);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var graphicsCard = await _context.GraphicsCards.FindAsync(id);
            _context.GraphicsCards.Remove(graphicsCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraphicsCardExists(int id)
        {
            return _context.GraphicsCards.Any(e => e.Id == id);
        }
    }
}
