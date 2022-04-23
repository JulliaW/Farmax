using Farmax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Farmax.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("projeto")
        {
        }

        public DbSet<ClienteModel> Cliente { get; set; }

        public DbSet<ProdutoModel> Produto { get; set; }
    }
}