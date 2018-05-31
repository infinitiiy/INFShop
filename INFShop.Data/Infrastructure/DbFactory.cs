﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private INFShopDbContext dbContext;
        public INFShopDbContext Init()
        {
            return dbContext ?? (dbContext = new INFShopDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
                dbContext.Dispose();
        }
    }
}
