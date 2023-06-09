using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RGR_FINAL.Data;
using RGR_FINAL.Data.Identity;

namespace RGR_FINAL.Pages.Lots
{
    public class CreateModel : PageModel
    {
        private readonly RGR_FINAL.Data.ApplicationDbContext _context;

        public CreateModel(RGR_FINAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lot Lot { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Lots == null || Lot == null)
            {
                return Page();
            }

            _context.Lots.Add(Lot);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
