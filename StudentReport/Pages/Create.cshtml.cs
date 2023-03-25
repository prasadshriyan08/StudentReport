using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentReport.Data;

namespace StudentReport.Pages
{
    public class CreateModel : PageModel
    {
        private readonly StudentReport.Data.StudentsDbContext _context;

        public CreateModel(StudentReport.Data.StudentsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Classes Classes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Classes == null || Classes == null)
            {
                return Page();
            }

            _context.Classes.Add(Classes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
