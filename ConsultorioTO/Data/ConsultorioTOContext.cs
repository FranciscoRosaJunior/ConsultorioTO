using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsultorioTO.Models;

namespace ConsultorioTO.Data
{
    public class ConsultorioTOContext : DbContext
    {
        public ConsultorioTOContext (DbContextOptions<ConsultorioTOContext> options)
            : base(options)
        {
        }

        public DbSet<ConsultorioTO.Models.Paciente> Paciente { get; set; }
    }
}
