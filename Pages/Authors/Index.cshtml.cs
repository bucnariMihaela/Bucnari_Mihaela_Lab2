using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bucnari_Mihaela_Lab2.Data;
using Bucnari_Mihaela_Lab2.Models;

namespace Bucnari_Mihaela_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Bucnari_Mihaela_Lab2.Data.Bucnari_Mihaela_Lab2Context _context;

        public IndexModel(Bucnari_Mihaela_Lab2.Data.Bucnari_Mihaela_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Author = await _context.Authors.ToListAsync();
            }
        }
    }
}
