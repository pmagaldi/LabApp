using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LabAppLibrary.Modelo;

namespace LabAppLibary.DB
{
    class LaboratorioContext : DbContext
    {
        public LaboratorioContext(string nomeDb): base(nomeDb)
        {

        }

        public DbSet<Laboratorio> Laboratorios { get; set; }
    }
}
