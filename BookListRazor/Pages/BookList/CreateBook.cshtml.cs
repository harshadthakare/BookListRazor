using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateBookModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateBookModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
