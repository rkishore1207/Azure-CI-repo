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
    public class IndexModel : PageModel
    {
        private readonly AzureContinuousIntegration.DataAccessLayer.AzureDbContext _context;

        public IndexModel(AzureContinuousIntegration.DataAccessLayer.AzureDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
