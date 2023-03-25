using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentReport.Data;

namespace StudentReport.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly StudentReport.Data.StudentsDbContext _context;

        public DeleteModel(StudentReport.Data.StudentsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Classes Classes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Classes == null)
            {
                return NotFound();
            }

            var classes = await _context.Classes.FirstOrDefaultAsync(m => m.Id == id);

            if (classes == null)
            {
                return NotFound();
            }
            else 
            {
                Classes = classes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Classes == null)
            {
                return NotFound();
            }
            var classes = await _context.Classes.FindAsync(id);

            if (classes != null)
            {
                Classes = classes;
                _context.Classes.Remove(Classes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
