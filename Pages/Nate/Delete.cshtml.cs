using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Data;
using RazorPagesMasterDetail.Models;

namespace RazorPagesMasterDetail.Pages.Nate
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext _context;

        public DeleteModel(RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Books Books { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Books.FirstOrDefaultAsync(m => m.ID == id);

            if (Books == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Books.FindAsync(id);

            if (Books != null)
            {
                _context.Books.Remove(Books);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
