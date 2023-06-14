using coffeeMVC.Data;
using coffeeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coffeeMVC.Controllers
{
    public class ItemOrderController : Controller
    {
        // GET: OrderController
        private readonly Data.CoffeManagementmvcContext _context;



        public ItemOrderController(CoffeManagementmvcContext context)
        {
            _context = context;
        }

        // GET: ItemOrder
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemOrders.ToListAsync());
        }


        // GET: ItemOrder/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new ItemOrder());
            else
                return View(_context.ItemOrders.Find(id));
        }

        // POST: ItemOrder/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,OrderId,ProductId,Quantity,UnitPrice")] ItemOrder itemOrder)
        {
            if (ModelState.IsValid)
            {
                if (itemOrder.Id == 0)
                {

                    _context.Add(itemOrder);
                }
                else
                    _context.Update(itemOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemOrder);
        }


        // POST: itemOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemOrder = await _context.ItemOrders.FindAsync(id);
            _context.ItemOrders.Remove(itemOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}


