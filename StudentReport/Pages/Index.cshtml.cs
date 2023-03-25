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
    public class IndexModel : PageModel
    {
        private readonly StudentReport.Data.StudentsDbContext _context;

        public IndexModel(StudentReport.Data.StudentsDbContext context)
        {
            _context = context;
        }

        public IList<Classes> Classes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Classes != null)
            {
                Classes = await _context.Classes.ToListAsync();
            }
        }
    }
}
