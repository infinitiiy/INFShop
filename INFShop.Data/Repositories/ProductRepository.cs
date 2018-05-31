using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFShop.Data.Infrastructure;
using INFShop.Model.Models;

namespace INFShop.Data.Repositories
{
    public interface IProductRepository
    {
        
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
