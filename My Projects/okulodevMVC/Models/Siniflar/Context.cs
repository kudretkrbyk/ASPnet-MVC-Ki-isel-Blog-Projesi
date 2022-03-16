using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace okulodevMVC.Models.Siniflar
{

    public class Context : DbContext
    {
        public DbSet<ForImage> ForImages { get; set; }
        public DbSet<yeni> yenis { get; set; }

    }
    
}
