using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureContinuousIntegration.DataAccessLayer;

namespace AzureContinuousIntegration.Pages_Persons
{
    public class DetailsModel : PageModel
    {
        private readonly AzureContinuousIntegration.DataAccessLayer.AzureDbContext _context;

        public DetailsModel(AzureContinuousIntegration.DataAccessLayer.AzureDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                Person = person;
            }
            return Page();
        }
    }
}
