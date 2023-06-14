using coffeeMVC.Data;
using coffeeMVC.Models;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coffeeMVC.Controllers
{
    public class DrinkController : Controller
    {
        // GET: OrderController
        private readonly Data.CoffeManagementmvcContext _context;



        public DrinkController(CoffeManagementmvcContext context)
        {
            _context = context;
        }

        // GET: ItemOrder
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drink.ToListAsync());
        }


        // GET: ItemOrder/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Drink());
            else
                return View(_context.Drink.Find(id));
        }

        // POST: ItemOrder/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Description,ImageUrl")] Drink drink)
        {
            if (ModelState.IsValid)
            {
                if (drink.Id == 0)
                {

                    _context.Add(drink);
                }
                else
                    _context.Update(drink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drink);
        }


        // POST: itemOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drink = await _context.Drink.FindAsync(id);
            _context.Drink.Remove(drink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Choix2()
        {
            return View();
        }
    }
}


