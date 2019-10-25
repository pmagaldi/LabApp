using LabAppLibrary.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppLibary.DB
{
    class RegistroContext : DbContext
    {
        public RegistroContext(string nomeDB) : base(nomeDB)
        {

        }

        public DbSet<Registro> Registros { get; set; }
    }
}
