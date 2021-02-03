using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Server.Models;

namespace Server.Pages
{
    public class CreateAvionModel : PageModel
    {
        [BindProperty]
        public Avion Avion { get; set; }

        private AvionContext avio;

        public CreateAvionModel(AvionContext context)
        {
            avio = context;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            avio.Avioni.Add(Avion);
            await avio.SaveChangesAsync();

            return RedirectToPage("./Avioni");
        }
    }
}
