using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMasterDetail.Models
{
    public class Books
    {
        public int ID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }
        
        [Required]
        public string Genre { get; set; }

        //May need to change image url code
        [DataType(DataType.ImageUrl)]
        public string Cover { get; set; }

        public string Summary { get; set; }
    }
}
