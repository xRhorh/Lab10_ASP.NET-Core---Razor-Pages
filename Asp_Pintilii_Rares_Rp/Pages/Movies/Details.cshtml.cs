using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp_Pintilii_Rares_Rp.Data;
using Asp_Pintilii_Rares_Rp.Models;

namespace Asp_Pintilii_Rares_Rp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Asp_Pintilii_Rares_Rp.Data.Asp_Pintilii_Rares_RpContext _context;

        public DetailsModel(Asp_Pintilii_Rares_Rp.Data.Asp_Pintilii_Rares_RpContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
