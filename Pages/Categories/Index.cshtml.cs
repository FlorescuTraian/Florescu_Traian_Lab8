using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Florescu_Traian_Lab8.Data;
using Florescu_Traian_Lab8.Models;

namespace Florescu_Traian_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Florescu_Traian_Lab8.Data.Florescu_Traian_Lab8Context _context;

        public IndexModel(Florescu_Traian_Lab8.Data.Florescu_Traian_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
