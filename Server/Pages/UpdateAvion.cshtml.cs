using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Pages
{
    public class UpdateAvionModel : PageModel
    {
        [BindProperty]
        public Avion Avion { get; set; }
        private AvionContext avio;

        public UpdateAvionModel(AvionContext context)
        {
            avio = context;
        }

        public async Task OnGet(int id)
        {
            Avion = await avio.Avioni.FindAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                Avion = await avio.Avioni.FindAsync(id);
                return Page();
            }

            Avion.ID = id;
            avio.Avioni.Update(Avion);
            await avio.SaveChangesAsync();

            return RedirectToPage("./Avioni");
        }
    }
}
