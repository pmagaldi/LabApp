using LabAppLibrary.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppLibary.DB
{
    public class MaquinaContext : DbContext
    {
        public MaquinaContext(string nomeDb) : base(nomeDb)
        {

        }

        public DbSet<Maquina> Maquinas { get; set; }
    }
}
