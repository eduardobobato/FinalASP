using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.Models
{
    public class Context : DbContext
    {
        public Context() : base("DbFinalASP") { }

         
        public DbSet<Usuario>   Usuarios   { get; set; }
        public DbSet<Vendedor>  Vendedores { get; set; }
        public DbSet<Cliente>   Clientes   { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto>   Produtos   { get; set; }
    }
}