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
    public class DeleteAvionModel : PageModel
    {
        private AvionContext avio;
        public DeleteAvionModel(AvionContext context)
        {
            avio = context;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var avion = avio.Avioni.Include(p => p.Lokacije).Where(p => p.ID == id).FirstOrDefault();
            avio.Avioni.Remove(avion);
            await avio.SaveChangesAsync();

            return RedirectToPage("./Avioni");
        }
    }
}
