using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace RazorPagesMasterDetail.Data
{
    public class RazorPagesMasterDetailContext : DbContext
    {
        public RazorPagesMasterDetailContext (DbContextOptions<RazorPagesMasterDetailContext> options)
            : base(options)
        {
            FilePath = @"Data/Books.json";

            // Only attempt to read the json data in if the filepath exists
            // And don't add the book if it has been added from somewhere else
            if (File.Exists(FilePath))
            {
                string booksData = File.ReadAllText(FilePath);
                List<Books> convertedData = JsonConvert.DeserializeObject<List<Books>>(booksData);
                foreach (Books book in convertedData)
                {
                    if (!Books.Contains(book)) Books.Add(book);
                }
            }
        }
        public override int SaveChanges()
        {
            string booksData = JsonConvert.SerializeObject(Books.ToList());
            File.WriteAllText(FilePath, booksData);
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            string booksData = JsonConvert.SerializeObject(Books.ToList());
            File.WriteAllText(FilePath, booksData);
            return base.SaveChangesAsync(cancellationToken);
        }
        private string FilePath { get; set; }
        public DbSet<RazorPagesMasterDetail.Models.Books> Books { get; set; }
    }
}
