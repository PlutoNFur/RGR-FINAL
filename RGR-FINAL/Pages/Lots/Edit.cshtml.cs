using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGR_FINAL.Data;
using RGR_FINAL.Data.Identity;

namespace RGR_FINAL.Pages.Lots
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly RGR_FINAL.Data.ApplicationDbContext _context;

        public EditModel(RGR_FINAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lot Lot { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Lots == null)
            {
                return NotFound();
            }

            var lot =  await _context.Lots.FirstOrDefaultAsync(m => m.Id == id);
            if (lot == null)
            {
                return NotFound();
            }
            Lot = lot;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LotExists(Lot.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LotExists(int id)
        {
          return (_context.Lots?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
