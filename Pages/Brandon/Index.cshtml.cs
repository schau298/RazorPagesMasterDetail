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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookGenre { get; set; }
        public string TitleSort { get; set; }
        public string DateSort { get; set; }

       
        public async Task OnGetAsync(string sortOrder)
        {
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            DateSort = sortOrder == "DateAsc" ? "DateDesc" : "DateAsc";

            //IQueryable<string> genreQuery = from b in _context.Books
            //                                orderby b.Genre
            //                                select b.Genre;

            var books = from b in _context.Books
                        select b;
            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(b => b.Title.Contains(SearchString));
            }

            //if (!string.IsNullOrEmpty(BookGenre))
            //{
            //    books = books.Where(x => x.Genre == BookGenre);
            //}

            switch (sortOrder)
            {
                case "TitleDesc":
                    books = books.OrderByDescending(b => b.Title);
                    break;
                case "DateDesc":
                    books = books.OrderByDescending(b => b.Date);
                    break;
                case "DateAsc":
                    books = books.OrderBy(b => b.Date);
                    break;
                default:
                    books = books.OrderBy(b => b.Title);
                    break;
            }
            // Use LINQ to get list of genres.

            //Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            Books = await books.AsNoTracking().ToListAsync();
        }
    }
}
