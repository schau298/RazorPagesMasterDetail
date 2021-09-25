using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Data;
using RazorPagesMasterDetail.Models;

namespace RazorPagesMasterDetail.Pages.Brandon
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext _context;

        public IndexModel(RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
