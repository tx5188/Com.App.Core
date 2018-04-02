using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.Data.Repository
{
    public interface IDbContextProvider<TDbContext>
          where TDbContext : DbContext
    {
        TDbContext GetDbContext();

       // TDbContext GetDbContext(MultiTenancySides? multiTenancySide);
    }
}
