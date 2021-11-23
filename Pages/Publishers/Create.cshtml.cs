using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tivadar_Ana_Maria_Lab8.Data;
using Tivadar_Ana_Maria_Lab8.Models;

namespace Tivadar_Ana_Maria_Lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Tivadar_Ana_Maria_Lab8.Data.Tivadar_Ana_Maria_Lab8Context _context;

        public CreateModel(Tivadar_Ana_Maria_Lab8.Data.Tivadar_Ana_Maria_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
