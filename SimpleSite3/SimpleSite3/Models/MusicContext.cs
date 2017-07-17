using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleSite3.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext()
        : base("SiteCatalog")
    { }

        public object CatalogList { get; internal set; }
        public DbSet<Music> CatalogListToList { get; set; }
    }
}