using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruyumController : ControllerBase
    {
        //private readonly ItemContext _context;

        //public TruyumController(ItemContext context)
        //{
        //    _context = context;
        //}

        List<ClsMenuItem> _context;
        public TruyumController()
        {
            _context = new List<ClsMenuItem>()
            {
            new ClsMenuItem{ItemId = 1, ItemName = "Apple",Price = 23, Active = true, Category = "Fruit", FreeDelivery ="Yes"},
            new ClsMenuItem{ItemId = 2, ItemName = "Mango",Price = 40, Active = false, Category = "Drink", FreeDelivery ="No"},
            new ClsMenuItem{ItemId = 3, ItemName = "Banana",Price = 23, Active = false, Category = "Fruit", FreeDelivery ="Yes"},
            new ClsMenuItem{ItemId = 4, ItemName = "Pineapple",Price = 50, Active = true, Category = "Drink", FreeDelivery ="No"},
            
            };
        }

        // GET: api/Truyum
        [HttpGet]
        public IEnumerable<ClsMenuItem> GetMenuItems()
        {
            return _context.ToList();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public ClsMenuItem GetItems(int id)
        {
            var item = _context[id];

            

            return item;
        }

        //// PUT: api/Customer/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutItem(int id, ClsMenuItem item)
        //{
        //    if (id != item.ItemId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(item).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Customer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<ClsMenuItem>> PostItem(ClsMenuItem item)
        //{
        //    _context.MenuItems.Add(item);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetItems", new { id = item.ItemId }, item);
        //}

        //// DELETE: api/Customer/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ClsMenuItem>> DeleteItem(int id)
        //{
        //    var item = await _context.MenuItems.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.MenuItems.Remove(item);
        //    await _context.SaveChangesAsync();

        //    return item;
        //}

        //private bool ItemExists(int id)
        //{
        //    return _context.MenuItems.Any(e => e.ItemId == id);
        //}
    }
}
