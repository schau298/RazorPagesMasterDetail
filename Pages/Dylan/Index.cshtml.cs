using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Data;
using RazorPagesMasterDetail.Models;

namespace RazorPagesMasterDetail.Pages.Dylan
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext _context;

        public IndexModel(RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string TitleSort { get; set; }
        public async Task OnGetAsync(string sortorder)
        {
            TitleSort = sortorder;
            var books = from b in _context.Books
                        select b;
            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(b => b.Title.Contains(SearchString));
            }
            if (TitleSort == "desc")
            {
                books = books.OrderByDescending(b => b.Title);
            }
            else
            {
                books = books.OrderBy(b => b.Title);
            }

            Books = await books.ToListAsync();
        }
    }
}

