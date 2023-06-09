using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RGR_FINAL.Data;
using RGR_FINAL.Data.Identity;

namespace RGR_FINAL.Pages.Lots
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RGR_FINAL.Data.ApplicationDbContext _context;

        public IndexModel(RGR_FINAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Lot> Lot { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Lots != null)
            {
                Lot = await _context.Lots.ToListAsync();
            }
        }
    }
}
