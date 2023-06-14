using coffeeMVC.Data;
using coffeeMVC.Models;
using coffeeMVC.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coffeeMVC.Controllers
{
    public class ProductController : Controller
    {


        // GET: OrderController
        private readonly Data.CoffeManagementmvcContext _context;


        public ProductController(CoffeManagementmvcContext context)
        {
            _context = context;
          
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }


        // GET: Transaction/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Product());
            else
                return View(_context.Products.Find(id));
        }

        // POST: Product/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Description,Category,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                {

                    _context.Add(product);
                }
                else
                    _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Pizza()
        {
            var pizzaProducts = _context.Products.Where(p => p.Name == "PIZZA").ToList();
            return View(pizzaProducts);
        }
        public IActionResult Plat()
        {
            var platProducts = _context.Products.Where(p => p.Name == "PLAT").ToList();
            return View(platProducts);
        }
        public IActionResult Crepe()
        {
            var crepeProducts = _context.Products.Where(p => p.Name == "CREPE").ToList();
            return View(crepeProducts);
        }
        public IActionResult Mojito()
        {
            var mojitoProducts = _context.Products.Where(p => p.Name == "MOJITO").ToList();
            return View(mojitoProducts);
        }
        public IActionResult Milkshake()
        {
            var milkshakeProducts = _context.Products.Where(p => p.Name == "MILKSHAKE").ToList();
            return View(milkshakeProducts);
        }
        public IActionResult Coffeeshake()
        {
            var coffeeProducts = _context.Products.Where(p => p.Name == "COFFEE").ToList();
            return View(coffeeProducts);
        }
        //    public IActionResult AddToCart(int productId)
        //    {
        //        var product = _context.Products.FirstOrDefault(p => p.Id == productId);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }

        //        // Add the product to the cart
        //     //   _cartService.AddToCart(product);

        //        // Redirect to the cart page
        //        return RedirectToAction("Cart");
        //    }



        //}




    }
}