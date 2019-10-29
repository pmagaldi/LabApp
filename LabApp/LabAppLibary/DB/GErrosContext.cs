using LabAppLibrary.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppLibary.DB
{
    class GErrosContext : DbContext
    {
        public GErrosContext(string nomeDb) : base(nomeDb)
        {

        }

        public DbSet<GruposDeErro> GruposErro { get; set; }
    }
}
