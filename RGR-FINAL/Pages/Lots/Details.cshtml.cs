using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RGR_FINAL.Data;
using RGR_FINAL.Data.Identity;

namespace RGR_FINAL.Pages.Lots
{
    public class DetailsModel : PageModel
    {
        private readonly RGR_FINAL.Data.ApplicationDbContext _context;

        public DetailsModel(RGR_FINAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Lot Lot { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Lots == null)
            {
                return NotFound();
            }

            var lot = await _context.Lots.FirstOrDefaultAsync(m => m.Id == id);
            if (lot == null)
            {
                return NotFound();
            }
            else 
            {
                Lot = lot;
            }
            return Page();
        }
    }
}
