using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFShop.Data.Infrastructure;
using INFShop.Model.Models;

namespace INFShop.Data
{
    public  class INFShopDbContext : DbContext
    {
        public INFShopDbContext() : base ("INFShop")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}
