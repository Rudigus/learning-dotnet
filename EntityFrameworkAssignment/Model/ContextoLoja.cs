using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkAssignment.Model
{
    class ContextoLoja : DbContext
    {
        public ContextoLoja()
            : base("DBLoja") { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
