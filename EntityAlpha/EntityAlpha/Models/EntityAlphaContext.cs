﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityAlpha.Models
{
    public class EntityAlphaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EntityAlphaContext() : base("name=EntityAlphaContext")
        {
        }

        public System.Data.Entity.DbSet<EntityAlpha.Models.Carro> Carroes { get; set; }
        public System.Data.Entity.DbSet<EntityAlpha.Models.Fabricante> Fabricantes { get; set; }
        public System.Data.Entity.DbSet<EntityAlpha.Models.Modelo> Modelos { get; set; }
        public System.Data.Entity.DbSet<EntityAlpha.Models.Usuario> Usuarios { get; set; }
        public System.Data.Entity.DbSet<EntityAlpha.Models.Aluguel> Alugueis { get; set; }
    }
}
