using coffeeMVC.Data;
using coffeeMVC.Models;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coffeeMVC.Controllers
{
    public class FoodController : Controller
    {
        // GET: OrderController
        private readonly Data.CoffeManagementmvcContext _context;



        public FoodController(CoffeManagementmvcContext context)
        {
            _context = context;
        }

        // GET: ItemOrder
        public async Task<IActionResult> Index()
        {
            return View(await _context.Food.ToListAsync());
        }


        // GET: ItemOrder/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Food());
            else
                return View(_context.Food.Find(id));
        }

        // POST: ItemOrder/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Description,ImageUrl")] Food food)
        {
            if (ModelState.IsValid)
            {
                if (food.Id == 0)
                {

                    _context.Add(food);
                }
                else
                    _context.Update(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }


        // POST: itemOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Food.FindAsync(id);
            _context.Food.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Choix2()
        {
            return View();
        }
    }
}


