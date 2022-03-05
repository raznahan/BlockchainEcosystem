using Model.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {

        public Context()
           : base("GraphConnectionString")
        {
        }

        public DbSet<Link> Links { get; set; }

        public DbSet<Node> Nodes { get; set; }
    }
}
