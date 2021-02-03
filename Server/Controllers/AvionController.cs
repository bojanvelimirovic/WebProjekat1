using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionController : ControllerBase
    {
        public AvionContext Context{get;set;}

        public AvionController(AvionContext context)
        {
            Context = context;
        }

        [Route("PreuzmiAvione")]
        [HttpGet]
        public async Task<List<Avion>> PreuzmiAvione()
        {
            return await Context.Avioni.Include(p => p.Lokacije).ToListAsync();
        }

        [Route("UpisiAvion")]
        [HttpPost]
        public async Task UpisiAvion([FromBody] Avion avion)
        {
            Context.Avioni.Add(avion);
            await Context.SaveChangesAsync();
        }

        [Route("IzmeniAvion")]
        [HttpPut]
        public async Task IzmeniAvion([FromBody] Avion avion)
        {
            //var stariAvion = await Context.Avioni.FindAsync(avion.ID);
            //stariAvion.Kapacitet = avion.Kapacitet;
            //stariAvion.Naziv = avion.Naziv;
           // stariAvion.X = avion.X;
            //stariAvion.Y = avion.Y;
            Context.Update<Avion>(avion);
            await Context.SaveChangesAsync();
        }

        [Route("ObrisiAvion")]
        [HttpDelete]
        public async Task ObrisiAvion(int id)
        {
            var avion = await Context.FindAsync<Avion>(id);
            Context.Remove(avion);
            await Context.SaveChangesAsync();
        }

        [Route("UpisLokacije/{idAviona}")]
        [HttpPost]
        public async Task UpisiLokaciju(int idAviona, [FromBody] Lokacija lok)
        {
            var avion = await Context.Avioni.FindAsync(idAviona);
            lok.Avion = avion;
            Context.Lokacije.Add(lok);
            await Context.SaveChangesAsync();
        }
    }
}
