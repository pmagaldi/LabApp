using LabAppLibrary.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppLibary.DB
{
    public class TErrosContext : DbContext
    {
        public TErrosContext(string nomeDb) : base(nomeDb)
        {

        }

        public DbSet<TiposDeErro> TiposErro { get; set; }
    }
}
