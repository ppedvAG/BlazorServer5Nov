using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul04
{
    public class AufgabenContext : DbContext
    {
        public AufgabenContext(DbContextOptions<AufgabenContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorServer5Nov.Pages.modul03.Aufgabe> Aufgabe { get; set; }
    }
}
