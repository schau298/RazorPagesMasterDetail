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
    public enum SortFields
    {
        None,
        Title,
        Author,
        Date
    }
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext _context;

        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public SortFields SortField { get; set; }

        public IndexModel(RazorPagesMasterDetail.Data.RazorPagesMasterDetailContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; }

        public async Task OnGetAsync()
        {
            var resources = _context.Books.Select(x => x);
            if (!string.IsNullOrEmpty(SearchString))
            {
                resources = resources.Where(book => book.Title.Contains(SearchString));
            }
            switch (SortField)
            {
                case SortFields.Title:
                    resources=resources.OrderBy(book=>book.Title);
                    break;
                case SortFields.Author:
                    resources = resources.OrderBy(book => book.Author);
                    break;
                case SortFields.Date:
                    resources = resources.OrderBy(book => book.Date);
                    break;
                default:
                    break;
            }
            Books = await resources.ToListAsync();
        }
    }
}
