﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bucnari_Mihaela_Lab2.Data;
using Bucnari_Mihaela_Lab2.Models;

namespace Bucnari_Mihaela_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Bucnari_Mihaela_Lab2.Data.Bucnari_Mihaela_Lab2Context _context;

        public CreateModel(Bucnari_Mihaela_Lab2.Data.Bucnari_Mihaela_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
