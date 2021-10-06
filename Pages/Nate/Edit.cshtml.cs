using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Data;
using RazorPagesMasterDetail.Models;

namespace RazorPagesMasterDetail.Pages.Nate
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext _context;

        public EditModel(RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Books).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BooksExists(Books.ID))
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

        private bool BooksExists(int id)
        {
            return _context.Books.Any(e => e.ID == id);
        }
    }
}
