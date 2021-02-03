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
    public class AvioniModel : PageModel
    {
        public List<Avion> Avioni { get; set; }
        private AvionContext avion;

        public AvioniModel(AvionContext context)
        {
            avion = context;
        }

        public async Task OnGetAsync()
        {
            Avioni = await avion.Avioni.ToListAsync();
        }
    }
}
